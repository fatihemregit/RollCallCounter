﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoklamaTutucu.Business.Abstracts;
using YoklamaTutucu.DataAcess.Concretes;
using YoklamaTutucu.models;

namespace YoklamaTutucu.Business.Concretes;

internal class IslemYapInMemoryManager : IIslemYapManager
{

    private IslemYapInMemory islemYap = new IslemYapInMemory();


    public int devamsizlikSayisiGetir(string dersIsmi = "")
    {
        return islemYap.devamsizlikSayisiGetir(dersIsmi);
    }
    public void DevamsizlikEkle(Dersdevamsizlik dersDevamsizlik)
    {
        //bu ders daha önceden devamsızlık olarak eklenmiş mi onu kontrol et(bu daha sonra eklenecek)
        islemYap.DevamsizlikEkle(dersDevamsizlik);
        Console.WriteLine($"devamsızlık ekleme başarılı\n şuan itibari ile\n{dersDevamsizlik.ders.adi} dersinin(dersi veren : {dersDevamsizlik.ders.hocasi})\n{dersDevamsizlik.dersDevamsizlikSayisi} adet devamsızlığı var");

    }

    public bool dersEkle(Ders ders)
    {
        //eğer ders eklenirse true,ders eklenmez ise false
        bool sonuc = false;
        //ders daha önceden var mı onu kontrol ediyoruz
        //sonradan aklıma geldi biz bunu küme veri tipi yapsak ya?(böylece 2 tane aynı ders eklenmez)(proje bittikten sonra değerlendir bunu)
        //yada listenin metotlarını kullanarak elemanın kontrolünü yapsak(Contains vs)
        //TODO burayı daha sonra test et hata çıkma potansiyeli var
        if (dersSayisi() > 0)
        {
            //foreach yerine where yada linq yapılabilir mi?

            var dersvarmi = (from fders in dersleriGetir()
                             where fders.adi.ToLower() == ders.adi.ToLower()
                             && fders.hocasi.ToLower() == ders.hocasi.ToLower()
                             select fders
                             ).FirstOrDefault();
            if (dersvarmi == null)
            {
                //ders eklenecek
                islemYap.dersEkle(ders);
                sonuc = true;
            }
            else
            {
                //ders eklenmeyecek
                sonuc = false;
            }

            //foreach (Ders fders in dersleriGetir())
            //{
            //    if (!(fders.adi.ToLower() == ders.adi.ToLower() && fders.hocasi.ToLower() == ders.hocasi.ToLower()))
            //    {
            //        //ders eklenecek
            //        islemYap.dersEkle(ders);
            //        sonuc = true;
            //        break;
            //    }
            //    else
            //    {
            //        //ders eklenmeyecek
            //        sonuc = false;
            //    }
            //}
        }
        else
        {
            //kayıtlı ders yok
            //ders eklenecek
            islemYap.dersEkle(ders);
            sonuc = true;
        }
        
        return sonuc;
    }

    public List<Ders> dersleriGetir()
    {
        return islemYap.dersleriGetir();
    }

    public int dersSayisi()
    {
       return islemYap.dersSayisi();
    }


    public List<Dersdevamsizlik> dersdevamsizliklarigetir()
    {
        return islemYap.dersdevamsizliklarigetir();
    }


    public List<Dersdevamsizlik> dersBazindaDevamsizlikGetir(Ders ders)
    {
        return islemYap.dersBazindaDevamsizlikGetir(ders);
    }
    public List<Dersdevamsizlik> tarihBazindaDevamsizlikGetir(DateTime tarih)
    {
        return islemYap.tarihBazindaDevamsizlikGetir(tarih);
    }

    public string veriBarindirmaTuru()
    {
        return islemYap.veriBarindirmaTuru();
    }


}
