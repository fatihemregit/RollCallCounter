// See https://aka.ms/new-console-template for more information

//main function codes start
while (true) {
    Console.Clear();
    Console.WriteLine("===============ANA MENÜ===============\n1-Devamsızlık Ekleme\n2- Ders Bazında Devamsızlık Görüntüleme\n3-Tarih bazında Devamsızlık Görüntüleme");
    string islemTip = girdiAl("işlem seçiniz");
    if (islemTip == "1") {
        //devamsızlık Ekleme
        Console.WriteLine("Devamsızlık ekleme");
    }
    else if (islemTip == "2") {
        Console.WriteLine("Ders Bazında Devamsızlık Görüntüleme");

    }
    else if(islemTip == "3")
    {
        Console.WriteLine("Tarih bazında Devamsızlık Görüntüleme");
    }
    else{
        Console.WriteLine("Bilinmeyen İşlem!!!");
    }

}
//main function codes end


//functions
string girdiAl(string soruMetni) {
    Console.WriteLine($"{soruMetni}");
    string kullaniciGirdisi = Console.ReadLine();
    return kullaniciGirdisi;
}
