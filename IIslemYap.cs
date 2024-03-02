using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoklamaTutucu.models;

namespace YoklamaTutucu;

public interface IIslemYap
{
    int devamsizlikSayisiGetir(string dersIsmi = "", int dersId = 0);
    void DevamsizlikEkle(Dersdevamsizlik dersDevamsizlik);

    void dersEkle(Ders ders);

    List<Ders> dersleriGetir();

    int dersSayisi();
    List<Dersdevamsizlik> dersdevamsizliklarigetir();
    List<Dersdevamsizlik> dersBazindaDevamsizlikGetir(Ders ders);
    List<Dersdevamsizlik> tarihBazindaDevamsizlikGetir(DateTime tarih);
}
