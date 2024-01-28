using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoklamaTutucu.models
{
    public class Dersdevamsizlik
    {
        public Ders ders;

        public int dersdevamsizliksayisi;

        public DateTime devamsizlikTarihi;
        public Dersdevamsizlik(Ders ders,int dersdevamsizliksayisi, DateTime devamsizlikTarihi)
        {
            this.ders = ders;
            this.devamsizlikTarihi = devamsizlikTarihi;
            this.dersdevamsizliksayisi = dersdevamsizliksayisi;
            //int dersdevamsizliksayisi,
        }
        public void devamsizlikArtir(int adet = 1)
        {
            dersdevamsizliksayisi = dersdevamsizliksayisi + adet;
        }


    }
}
