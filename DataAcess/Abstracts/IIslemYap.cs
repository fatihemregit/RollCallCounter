using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoklamaTutucu.models;

namespace YoklamaTutucu.DataAcess.Abstracts;

public interface IIslemYap
{
    string veriBarindirmaTuru();
    int devamsizlikSayisiGetir(string dersIsmi = "");
    void DevamsizlikEkle(Dersdevamsizlik dersDevamsizlik);

    bool dersEkle(Ders ders);

    List<Ders> dersleriGetir();

    int dersSayisi();
    List<Dersdevamsizlik> dersdevamsizliklarigetir();
    List<Dersdevamsizlik> dersBazindaDevamsizlikGetir(Ders ders);
    List<Dersdevamsizlik> tarihBazindaDevamsizlikGetir(DateTime tarih);
}
