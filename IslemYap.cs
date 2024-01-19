using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoklamaTutucu.models;

namespace YoklamaTutucu
{
    public class IslemYap
    {
        private List<Dersdevamsizlik> dersDevamsizliklar;
        private List<Ders> dersler = new List<Ders>();

        public IslemYap()
        {
            //programın hata vermemesi için örnek bir ders oluşturuyoruz
            //dersler.Add(new Ders("deneme","denemeoğlu"));
        }

        public void DevamsizlikEkle(Dersdevamsizlik dersDevamsizlik) {
            //bu ders daha önceden devamsızlık olarak eklenmiş mi onu kontrol et(bu daha sonra eklenecek)
            //Devamsızlık ekleme işlemi
            //kullanıcı onayı alma

            Console.WriteLine($"{dersDevamsizlik.devamsizlikTarihi} tarihinde\n{dersDevamsizlik.ders.adi} adında(dersi veren : {dersDevamsizlik.ders.hocasi})\n{dersDevamsizlik.dersdevamsizliksayisi} adet devamsızlığınız olan(eğer eklerseniz devamsızlığınız {dersDevamsizlik.dersdevamsizliksayisi + 1 } adet olacak ) ders eklenecek\n onaylamak için herhangi bir tuşa basın(iptal için i)");
            string onay2 = Console.ReadLine();
            if (!(onay2 == "i" || onay2 == "İ")) {
                //onay verildi
                dersDevamsizlik.devamsizlikArtir();
                dersDevamsizliklar.Add(dersDevamsizlik);
                Console.WriteLine("devamsızlık ekleme başarılı\n şuan itibari ile\n{} dersinin(dersi veren : {ders.hocasi})\n{ders.dersdevamsizliksayisi}adet devamsızlığı var");
            }
            else
            {
                //onay verilmedi
                Console.WriteLine("devamsızlık eklenmedi");
            }
        }
        public bool dersEkle(Ders ders) {
            Console.WriteLine();
            //eğer ders eklenirse true,ders eklenmez ise false
            bool sonuc = false;
            //ders daha önceden var mı onu kontrol ediyoruz
            //TODO burayı daha sonra test et hata çıkma potansiyeli var
            if (dersSayisi() > 0) {
                //ders var
                Console.WriteLine("ders ekleme islemyap");
                Console.ReadLine();
                foreach (Ders fders in dersler) //tam olarak burada hata veriyor
                {
                    if (!((fders.adi.ToLower() == ders.adi.ToLower()) && (fders.hocasi.ToLower() == ders.hocasi.ToLower())))
                    {
                        //ders eklenecek
                        //(ders.adi.ToLower() == fders.adi.ToLower()) && (ders.hocasi.ToLower() != fders.hocasi.ToLower())
                        Console.WriteLine("ders ekle foreach if");
                        dersler.Add(ders);
                        sonuc = true;
                        break;
                    }
                    else
                    {
                        //ders eklenmeyecek
                        sonuc = false;
                    }

                }
            }
            else
            {
                //ders yok
                dersler.Add(ders);
            }
            
            return sonuc;
        }
        public List<Ders> dersleriGetir()
        {
            return dersler;
        }
        public int dersSayisi()
        {
        
            return dersler.Count();
        }
    }
}
