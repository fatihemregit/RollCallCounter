using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoklamaTutucu.DataAcess.Abstracts;
using YoklamaTutucu.models;

namespace YoklamaTutucu.DataAcess.Concretes;

public class IslemYapInMemory : IIslemYap
{
    private List<Dersdevamsizlik> dersDevamsizliklar = new List<Dersdevamsizlik>();
    private List<Ders> dersler = new List<Ders>();
    private Dictionary<string, int> dersDevamsizlikSayisi = new Dictionary<string, int>();
    public IslemYapInMemory()
    {
        //programın hata vermemesi için örnek bir ders oluşturuyoruz
        //dersler.Add(new Ders("deneme","denemeoğlu"));
    }
    public int devamsizlikSayisiGetir(string dersIsmi = "")
    {
        return dersDevamsizlikSayisi[dersIsmi];
    }
    //devamsızlık ekleme ile ilgili işlemler başlangıç
    public void DevamsizlikEkle(Dersdevamsizlik dersDevamsizlik)
    {

        //bu ders daha önceden devamsızlık olarak eklenmiş mi onu kontrol et(bu daha sonra eklenecek)
        //Devamsızlık ekleme işlemi
        dersDevamsizlik.devamsizlikArtir();
        dersDevamsizlikSayisi[dersDevamsizlik.ders.adi] = dersDevamsizlik.dersDevamsizlikSayisi;
        dersDevamsizliklar.Add(dersDevamsizlik);

    }
    public bool dersEkle(Ders ders)
    {
        //eğer ders eklenirse true,ders eklenmez ise false
        //ders yok
        dersler.Add(ders);
        dersDevamsizlikSayisi.Add(ders.adi, 0); // burayı daha sonra düzeltme ihtiyacı doğabilir

        return true;
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
    public List<Dersdevamsizlik> dersBazindaDevamsizlikGetir(Ders ders)
    {
        //linq sorgusuna çevirilebilir.

        //yeni yöntem başlangıç
        return dersDevamsizliklar.Where(dersdevamsizlik => dersdevamsizlik.ders.adi == ders.adi && dersdevamsizlik.ders.hocasi == ders.hocasi).ToList();
        //yeni yöntem bitiş

        //eski yöntem başlangıç
        //List<Dersdevamsizlik> devamsizlikListesi = new List<Dersdevamsizlik>();
        //foreach (Dersdevamsizlik dersdevamsizlik in dersDevamsizliklar) {
        //    if ((dersdevamsizlik.ders.adi == ders.adi) && (dersdevamsizlik.ders.hocasi == ders.hocasi)) {
        //        //eşleşme olumlu
        //        devamsizlikListesi.Add(dersdevamsizlik);
        //    }
        //}
        //return devamsizlikListesi;
        //eski yöntem bitiş
    }
    //devamsızlık görüntülüme(ders bazında) bitiş

    //devamsızlık görüntüleme (tarih bazında) başlangıç
    public List<Dersdevamsizlik> tarihBazindaDevamsizlikGetir(DateTime tarih)
    {
        //yeni yöntem başlangıç
        return dersDevamsizliklar.Where(dersDevamsizlik => dersDevamsizlik.devamsizlikTarihi.ToShortDateString() == tarih.ToShortDateString()).ToList();
        //yeni yöntem bitiş
        //eski yöntem başlangıç
        //List<Dersdevamsizlik> devamsizlikListesi = new List<Dersdevamsizlik>();
        //foreach (Dersdevamsizlik dersdevamsizlik in dersDevamsizliklar)
        //{
        //    if (dersdevamsizlik.devamsizlikTarihi.ToShortDateString() == tarih.ToShortDateString()) { 
        //        //eşleşme sağlandı
        //        devamsizlikListesi.Add(dersdevamsizlik);
        //    }
        //}
        //return devamsizlikListesi;
        //eski yöntem bitiş
    }
    //devamsızlık görüntüleme (tarih bazında) bitiş

    public string veriBarindirmaTuru()
    {
        return "In memory";
    }


}
