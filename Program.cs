// See https://aka.ms/new-console-template for more information

//main function codes start
using System;
using YoklamaTutucu;
using YoklamaTutucu.models;
using static System.Net.Mime.MediaTypeNames;

IslemYap islemYap = new IslemYap();
string devamsizlikIptalBilgilendirmeYazisi = "(devamsızlık ekleme işlemi iptal edildi ana menüye dönmek için bir tuşa basın)";
while (true)
{
    Console.Clear();
    Console.WriteLine("===============ANA MENÜ===============\n1-Devamsızlık Ekleme\n2- Ders Bazında Devamsızlık Görüntüleme\n3-Tarih bazında Devamsızlık Görüntüleme");
    string islemTip = girdiAl("işlem seçiniz");
    if (islemTip == "1")
    {

        //devamsızlık Ekleme
        Console.WriteLine("Devamsızlık ekleme");
        Console.WriteLine("Devamsızlık ekleme işlemi 3 işlemden oluşmaktadır\n1.işlem:Ders Seçimi\n2.işlem:Tarih Seçimi\n3.işlem:onay işlemi");
        Ders? devamszilikEklemeSecilenDers;
        //ders seçimi
        devamszilikEklemeSecilenDers = DevamsizlikEklemeIslemiicinDersSecim();
        if (devamszilikEklemeSecilenDers == null)
        {
            //ders seçiminde hata var 
            continue;
        }

        //Tarih seçimi
        DateTime? SecilenTarih = TarihSecim(devamsizlikIptalBilgilendirmeYazisi);
        if (SecilenTarih == null)
        {
            //Tarih seçiminde hata var
            continue;
        }
        //dersi ekleme ve onay alma
        Console.WriteLine("\n3.işlem:onay işlemi");
        Console.WriteLine($"Seçilen Ders:{devamszilikEklemeSecilenDers.adi}\nSeçilen Tarih:{SecilenTarih.Value.ToShortDateString()}");
        Dersdevamsizlik devamsizlikEklemeDersDevamsizlik = new Dersdevamsizlik(devamszilikEklemeSecilenDers,islemYap.devamsizlikSayisiGetir(devamszilikEklemeSecilenDers.adi),Convert.ToDateTime(SecilenTarih));
        islemYap.DevamsizlikEkle(devamsizlikEklemeDersDevamsizlik);
        Console.ReadLine();

    }
    else if (islemTip == "2")
    {
        Console.WriteLine("Ders Bazında Devamsızlık Görüntüleme");
        //eğer devamsızlık yapılan ders yoksa devamsızlık görüntülenemez
        if (islemYap.dersdevamsizliklarigetir().Count == 0)
        {
            Console.WriteLine("Devamsızlık olmadığından devamsızlık görüntülenemeyiyor\n(Ana menüye dönmek için bir tuşa basın)");
            Console.ReadLine();
            continue;
        }
        Console.WriteLine("Ders Bazında Devamsızlık Görüntüleme işlemi 2 aşamadan oluşmaktadır\n1.Ders Seçimi\n2.Devamsızlık Görüntüleme\n");
        //varolan derslerden ders seçimi

        Ders? dersBazindaDevamszilikGoruntulemeSecilenDers = DersBazindaDevamsizlikGoruntulemeicinDersSecimi();
        if (dersBazindaDevamszilikGoruntulemeSecilenDers == null) {
            //ders seçiminde bir hata olmuş ana menüye dönülüyor
            continue;
        }
        // Devamsızlık görüntüleme işlemi
        Console.WriteLine("\n2.işlem:Devamsızlık Görüntüleme");
        Console.WriteLine("Ders Adı|Ders Hocası|Devamsızlık Tarihi");
        foreach (Dersdevamsizlik dersBazindaDevamsizlikGoruntulemeDersDevamsizlik in islemYap.dersBazindaDevamsizlikGetir(dersBazindaDevamszilikGoruntulemeSecilenDers)) {
            Console.WriteLine($"{dersBazindaDevamsizlikGoruntulemeDersDevamsizlik.ders.adi}|{dersBazindaDevamsizlikGoruntulemeDersDevamsizlik.ders.hocasi}|{dersBazindaDevamsizlikGoruntulemeDersDevamsizlik.devamsizlikTarihi.ToShortDateString()}");
        }
        Console.ReadLine();



    }
    else if (islemTip == "3")
    {
        Console.WriteLine("Tarih bazında Devamsızlık Görüntüleme");
        //eğer devamsızlık yapılan ders yoksa devamsızlık görüntülenemez
        if (islemYap.dersdevamsizliklarigetir().Count == 0)
        {
            Console.WriteLine("Devamsızlık olmadığından devamsızlık görüntülenemeyiyor\n(Ana menüye dönmek için bir tuşa basın)");
            Console.ReadLine();
            continue;
        }
        Console.WriteLine("Tarih Bazında Devamsızlık Görüntüleme işlemi 2 aşamadan oluşmaktadır\n1.Tarih Seçimi\n2.Devamsızlık Görüntüleme\n");
        //tarih Seçimi
        DateTime? tarihbazindaDevamsizlikGoruntulemeSecilenTarih = TarihSecim("(Tarih Bazında Devamsızlık Görüntüleme işlemi iptal edildi ana menüye dönmek için bir tuşa basın)","1.işlem:Tarih Seçimi");
        if (tarihbazindaDevamsizlikGoruntulemeSecilenTarih == null) {
            //tarih seçiminde bir hata olmuş ana menüye dönülüyor
            continue;
        }
        // Devamsızlık görüntüleme işlemi
        Console.WriteLine("\n2.işlem:Devamsızlık Görüntüleme");
        Console.WriteLine("Ders Adı|Ders Hocası|Devamsızlık Tarihi");
        foreach (Dersdevamsizlik tarihBazindaDevamsizlikGoruntulemeDersDevamsizlik in islemYap.tarihBazindaDevamsizlikGetir(Convert.ToDateTime(tarihbazindaDevamsizlikGoruntulemeSecilenTarih))) {
            Console.WriteLine($"{tarihBazindaDevamsizlikGoruntulemeDersDevamsizlik.ders.adi}|{tarihBazindaDevamsizlikGoruntulemeDersDevamsizlik.ders.hocasi}|{tarihBazindaDevamsizlikGoruntulemeDersDevamsizlik.devamsizlikTarihi.ToShortDateString()}");
        }
        Console.ReadLine();

    }
    else if(islemTip == "4")
    {
        Console.WriteLine("Test Menü");
        Console.WriteLine("Ders Adı|Ders Hocası|Devamsızlık Tarihi|");

        foreach (Dersdevamsizlik item in islemYap.dersdevamsizliklarigetir())
        {
            Console.WriteLine($"{item.ders.adi}|{item.ders.hocasi}|{item.devamsizlikTarihi.ToShortDateString()}|");
        }
        Console.ReadLine();
    }
    else if (islemTip == "5") {
        Console.WriteLine("çıkış yapılıyor");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Bilinmeyen İşlem!!!\nana menüye dönmek için bir tuşa basın");
        Console.ReadLine();
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

bool emptyDataCheckForDersEkle(string kontrolverisi, string kullaniciyaSoyle)
{
    //eğer veride boşluk sıkıntısı varsa(boş bırakma,başındaboşluk,sonundaboşluk) true döndürür.sıkıntı yoksa false
    bool basindaBoslukVarmi = kontrolverisi.StartsWith(" ");
    bool sonundaBoslukVarmi = kontrolverisi.EndsWith(" ");
    if ((kontrolverisi == "") || (kontrolverisi == " ") || (basindaBoslukVarmi) || (sonundaBoslukVarmi))
    {
        Console.WriteLine($"boş değer hatası(aşağıdaki nedenlerden dolayı hata aldınız\n1-{kullaniciyaSoyle} boş bırakılamaz\n2-{kullaniciyaSoyle} boşluk ile başlayamaz\n3-{kullaniciyaSoyle} boşluk ile bitemez)");
        return true;
    }
    return false;
}
Ders? dersEkle()
{
    string dersadi = girdiAl("eklenecek dersin adı");
    //empty Data Check for dersAdi Variable(dersadı değişkeni için boş veri kontrolü)
    if (emptyDataCheckForDersEkle(dersadi, "eklencek dersin adı"))
    {
        return null;
    }
    string dersHocasi = girdiAl("dersi veren öğretim görevlisi");
    //empty Data Check for dersHocasi Variable(dersHocasi değişkeni için boş veri kontrolü)
    if (emptyDataCheckForDersEkle(dersHocasi, "dersi veren öğretim görevlisi"))
    {
        return null;
    }
    Ders SecilenDers = new Ders(dersadi, dersHocasi);
    return SecilenDers;
}

Ders? DersBazindaDevamsizlikGoruntulemeicinDersSecimi()
{
    Console.WriteLine("\n1.işlem:ders seçimi");
    Ders? ders;
    int sayac = 0;


    foreach (Ders d in islemYap.dersleriGetir())
    {
        Console.WriteLine($"{sayac}-{d.adi}(dersi veren:{d.hocasi})");
        sayac++;
    }
    string girdi = girdiAl("Lütfen yukarıdan numaraya göre ders seçimi yapınız");
    try
    {
        int dersindex = Convert.ToInt32(girdi);
        ders = islemYap.dersleriGetir()[dersindex];
    }
    catch (Exception e)
    {
        Console.WriteLine("Hatalı seçim\n(olmayan ders seçimi veya hatalı girdi(yalnızca sayı kabul edilir)\nAna menüye dönmek için bir tuşa basın");
        Console.ReadLine();
        return null;
    }

    return ders;
}
Ders? DevamsizlikEklemeIslemiicinDersSecim()
{
    //ders seçimi
    //ders seçimi başlangıç
    Console.WriteLine("\n1.işlem:ders seçimi");
    Ders? SecilenDers;
    if (islemYap.dersSayisi() > 0)
    {
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
            if (SecilenDers == null)
            {
                Console.WriteLine("Ders Seçimi başarısız ana menüye dönmek için bir tuşa basın");
                Console.ReadLine();
                return null;

            }

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
                return null;
            }
        }
    }
    else
    {
        //hiç ders yok
        Console.WriteLine("hiç ders olmadığından ders ekleme kodları çalışyor");
        //yeni ders ekleme
        SecilenDers = dersEkle();
        if (SecilenDers == null)
        {
            Console.WriteLine("Ders Seçimi başarısız ana menüye dönmek için bir tuşa basın");
            Console.ReadLine();
            return null;

        }
        islemYap.dersEkle(SecilenDers);
        Console.WriteLine("Yeni ders ekleme işlemi başarılı");

    }
    Console.WriteLine($"Ders Seçimi başarılı\nSeçtiğiniz Ders:{SecilenDers.adi}({SecilenDers.hocasi})");
    //ders seçimi bitiş
    return SecilenDers;
}



DateTime? TarihSecim(string iptalBilgilendirmeYazisi, string islemBilgilendirmeYazisi = "2.işlem : Tarih Seçimi")
{
    //Tarih seçimi
    //Tarih seçimi başlangıç
    Console.WriteLine($"\n{islemBilgilendirmeYazisi}");
    DateTime SecilenTarih;
    Console.WriteLine($"0-Bugünün Tarihi : {DateTime.Now.ToShortDateString()}");
    Console.WriteLine($"1-Farklı Bir Tarih");
    Console.WriteLine("Lütfen yukarıdan numaraya göre tarih seçimi yapınız");
    String girdi2 = Console.ReadLine();
    if (girdi2 == "0")
    {
        //seçilen tarih bugünün tarihi
        Console.WriteLine($"Bugünün Tarihi({DateTime.Now.ToShortDateString()}) ni seçtiniz ");
        SecilenTarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());
    }
    else if (girdi2 == "1")
    {
        //seçilen tarih farklı bir tarih
        Console.WriteLine("Tarih giriniz");
        //not:olduğumuz tarihden daha büyük tarih seçilemez
        DateTime kullanicininGirdigiTarih;
        if (!(DateTime.TryParse(Console.ReadLine(), out kullanicininGirdigiTarih)))
        {
            //tarih seçim işlemi başarısız
            Console.WriteLine($"tarih girişi başarısız\n{iptalBilgilendirmeYazisi}");
            Console.ReadLine();
            return null;
        }

        if (kullanicininGirdigiTarih > Convert.ToDateTime(DateTime.Now.ToShortDateString()))
        {
            Console.WriteLine($"Girdiğiniz tarih bugünden sonraki bir tarih olamaz\n{iptalBilgilendirmeYazisi}");
            Console.ReadLine();
            return null;
        }
        SecilenTarih = kullanicininGirdigiTarih;
    }
    else
    {
        Console.WriteLine($"geçersiz işlem\n{iptalBilgilendirmeYazisi}");
        Console.ReadLine();
        return null;
    }
    Console.WriteLine($"Tarih seçimi Başarılı seçtiğiniz tarih {SecilenTarih.ToShortDateString()}");
    //Tarih seçimi bitiş
    return SecilenTarih;
}