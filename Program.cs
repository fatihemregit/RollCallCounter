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
        Console.WriteLine(islemYap.dersSayisi());
        //devamsızlık Ekleme
        Console.WriteLine("Devamsızlık ekleme");
        //ders seçimi
        Ders SecilenDers;
        if (islemYap.dersSayisi() > 0) {
            Console.WriteLine("ders var ifi");
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
        }
        islemYap.dersEkle(SecilenDers);
        
        



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