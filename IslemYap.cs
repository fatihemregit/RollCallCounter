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
        private List<Dersdevamsizlik> dersDevamsizliklar = new List<Dersdevamsizlik>();
        private List<Ders> dersler = new List<Ders>();
        private Dictionary<string,int> dersDevamsizlikSayisi = new Dictionary<string,int>();
        public IslemYap()
        {
            //programın hata vermemesi için örnek bir ders oluşturuyoruz
            //dersler.Add(new Ders("deneme","denemeoğlu"));
        }
        public int devamsizlikSayisiGetir(string dersIsmi)
        {
            return dersDevamsizlikSayisi[dersIsmi];
        }
        //devamsızlık ekleme ile ilgili işlemler başlangıç
        public void DevamsizlikEkle(Dersdevamsizlik dersDevamsizlik) {
            //bu ders daha önceden devamsızlık olarak eklenmiş mi onu kontrol et(bu daha sonra eklenecek)
            //Devamsızlık ekleme işlemi
            //kullanıcı onayı alma

            Console.WriteLine($"{dersDevamsizlik.devamsizlikTarihi.ToShortDateString()} tarihinde\n {dersDevamsizlik.ders.adi} adında(dersi veren : {dersDevamsizlik.ders.hocasi})\n{dersDevamsizlik.dersdevamsizliksayisi} adet devamsızlığınız olan(eğer eklerseniz devamsızlığınız {dersDevamsizlik.dersdevamsizliksayisi + 1 } adet olacak ) devamsızlık eklenecek\n onaylamak için herhangi bir tuşa basın(iptal için i)");
            string onay2 = Console.ReadLine();
            if (!(onay2 == "i" || onay2 == "İ")) {
                //onay verildi
                dersDevamsizlik.devamsizlikArtir();
                dersDevamsizlikSayisi[dersDevamsizlik.ders.adi] = dersDevamsizlik.dersdevamsizliksayisi;
                dersDevamsizliklar.Add(dersDevamsizlik);
                Console.WriteLine($"devamsızlık ekleme başarılı\n şuan itibari ile\n{dersDevamsizlik.ders.adi} dersinin(dersi veren : {dersDevamsizlik.ders.hocasi})\n{dersDevamsizlik.dersdevamsizliksayisi} adet devamsızlığı var");
            }
            else
            {
                //onay verilmedi
                Console.WriteLine("devamsızlık eklenmedi");
            }
        }
        public bool dersEkle(Ders ders) {
            //eğer ders eklenirse true,ders eklenmez ise false
            bool sonuc = false;
            //ders daha önceden var mı onu kontrol ediyoruz
            //sonradan aklıma geldi biz bunu küme veri tipi yapsak ya?(böylece 2 tane aynı ders eklenmez)(proje bittikten sonra değerlendir bunu)
            //yada listenin metotlarını kullanarak elemanın kontrolünü yapsak(Contains vs)
            //TODO burayı daha sonra test et hata çıkma potansiyeli var
            if (dersSayisi() > 0) {
                //ders var
                foreach (Ders fders in dersler) //tam olarak burada hata veriyor
                {
                    if (!((fders.adi.ToLower() == ders.adi.ToLower()) && (fders.hocasi.ToLower() == ders.hocasi.ToLower())))
                    {
                        //ders eklenecek
                        //(ders.adi.ToLower() == fders.adi.ToLower()) && (ders.hocasi.ToLower() != fders.hocasi.ToLower());
                        dersler.Add(ders);
                        dersDevamsizlikSayisi.Add(ders.adi, 0); // burayı daha sonra düzeltme ihtiyacı doğabilir
                        Console.ReadLine();
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
                dersDevamsizlikSayisi.Add(ders.adi, 0); // burayı daha sonra düzeltme ihtiyacı doğabilir

                sonuc = true;
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
        public List<Dersdevamsizlik> dersdevamsizliklarigetir()
        {
            return dersDevamsizliklar;
        }
        //devamsızlık ekleme ile ilgili işlemler bitiş

        //devamsızlık görüntülüme(ders bazında) başlangıç
        public List<Dersdevamsizlik> dersBazindaDevamsizlikGetir(Ders ders) {
            List<Dersdevamsizlik> pleaseReturn = new List<Dersdevamsizlik>();
            foreach (Dersdevamsizlik dersdevamsizlik in dersDevamsizliklar) {
                if ((dersdevamsizlik.ders.adi == ders.adi) && (dersdevamsizlik.ders.hocasi == ders.hocasi)) {
                    //eşleşme olumlu
                    pleaseReturn.Add(dersdevamsizlik);
                }
            }
            return pleaseReturn;
        }
        //devamsızlık görüntülüme(ders bazında) bitiş



    }
}
