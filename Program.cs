// See https://aka.ms/new-console-template for more information

//main function codes start
using YoklamaTutucu;
using YoklamaTutucu.models;

IslemYap islemYap = new IslemYap();
while (true)
{
    Console.Clear();
    Console.WriteLine("===============ANA MENÜ===============\n1-Devamsızlık Ekleme\n2- Ders Bazında Devamsızlık Görüntüleme\n3-Tarih bazında Devamsızlık Görüntüleme");
    string islemTip = girdiAl("işlem seçiniz");
    if (islemTip == "1")
    {

        //devamsızlık Ekleme
        Console.WriteLine("Devamsızlık ekleme");
        Console.WriteLine("Devamsızlık ekleme işlemi 3 işlemden oluşmaktadır\n1.işlem:Ders Seçimi\n2.işlem:Tarih Seçimi\n3.işlem:onay");

        //ders seçimi
        Console.WriteLine("\n1.işlem:ders seçimi");
        Ders SecilenDers;
        if (islemYap.dersSayisi() > 0) {
            //ders var
            int sayac = 0;
            foreach (Ders d in islemYap.dersleriGetir())
            {

                Console.WriteLine($"{sayac}-{d.adi}(dersi veren:{d.hocasi})");
                sayac++;
            }
            string girdi = girdiAl("Lütfen yukarıdan numaraya göre ders seçimi yapınız(yeni ders eklemek için e tuşuna basın)");
            if (girdi == "e" || girdi == "E")
            {
                //yeni ders ekleme
                SecilenDers = dersEkle();
                islemYap.dersEkle(SecilenDers);
                Console.WriteLine("Yeni ders ekleme işlemi başarılı");

            }
            else
            {
                //eklenen derslerden seçim yapma
                try
                {
                    int ders = Convert.ToInt32(girdi);
                    SecilenDers = islemYap.dersleriGetir()[ders];
                }
                catch
                {
                    Console.WriteLine("Ders Seçimi başarısız ana menüye dönmek için bir tuşa basın");
                    Console.ReadLine();
                    continue;
                }
            }
        }
        else
        {
            //hiç ders yok
            Console.WriteLine("hiç ders olmadığından ders ekleme kodları çalışyor");
            //yeni ders ekleme
            SecilenDers = dersEkle();
            islemYap.dersEkle(SecilenDers);
            Console.WriteLine("Yeni ders ekleme işlemi başarılı");

        }
        Console.WriteLine($"Ders Seçimi başarılı\nSeçtiğiniz Ders:{SecilenDers.adi}({SecilenDers.hocasi})");
        Console.WriteLine("2.işlem : Tarih Seçimi");
        //Tarih seçimi
        DateTime SecilenTarih;
        Console.WriteLine($"0-Bugünün Tarihi : {DateTime.Now.ToShortDateString()}");
        Console.WriteLine($"1-Farklı Bir Tarih");
        Console.WriteLine("Lütfen yukarıdan numaraya göre tarih seçimi yapınız");
        String girdi2 = Console.ReadLine();
        if (girdi2 == "0") {
            //seçilen tarih bugünün tarihi
            Console.WriteLine($"Bugünün Tarihi({DateTime.Now.ToShortDateString()}) ni seçtiniz ");
            SecilenTarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        } 
        else if (girdi2 == "1") {
            //seçilen tarih farklı bir tarih
            Console.WriteLine("Tarih giriniz");
            //not:olduğumuz tarihden daha büyük tarih seçilemez
            DateTime kullanicininGirdigiTarih;
            if (!(DateTime.TryParse(Console.ReadLine(), out kullanicininGirdigiTarih)))
            {
                //tarih seçim işlemi başarısız
                Console.WriteLine("tarih girişi başarısız\n(devamsızlık ekleme işlemi iptal edildi ana menüye dönmek için bir tuşa basın)");
                Console.ReadLine();
                continue;
            }

            if (kullanicininGirdigiTarih > Convert.ToDateTime(DateTime.Now.ToShortDateString())) {
                Console.WriteLine("Girdiğiniz tarih bugünden sonraki bir tarih olamaz\n(devamsızlık ekleme işlemi iptal edildi ana menüye dönmek için bir tuşa basın)");
                Console.ReadLine();
                continue;
            }
            SecilenTarih = kullanicininGirdigiTarih;
        }
        else
        {
            Console.WriteLine("geçersiz işlem Ana menüye döndürülüyorsunuz");
            Console.ReadLine();
            continue;
        }
        Console.WriteLine($"Tarih seçimi Başarılı seçtiğiniz tarih {SecilenTarih.ToShortDateString()}");
        Console.ReadLine();
        //islemYap.DevamsizlikEkle();

    }
    else if (islemTip == "2")
    {
        Console.WriteLine("Ders Bazında Devamsızlık Görüntüleme");

    }
    else if (islemTip == "3")
    {
        Console.WriteLine("Tarih bazında Devamsızlık Görüntüleme");
    }
    else
    {
        Console.WriteLine("Bilinmeyen İşlem!!!");
    }

}
//main function codes end


//functions
string girdiAl(string soruMetni)
{
    Console.WriteLine($"{soruMetni}");
    string kullaniciGirdisi = Console.ReadLine();
    return kullaniciGirdisi;
}
Ders dersEkle()
{
    string dersadi = girdiAl("eklenecek dersin adı");
    string dersHocasi = girdiAl("dersi veren öğretim görevlisi");
    Ders SecilenDers = new Ders(dersadi, dersHocasi);
    return SecilenDers;
}