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

        public int dersdevamsizliksayisi = 0;

        public DateTime devamsizlikTarihi;
        public Dersdevamsizlik(Ders ders, int dersdevamsizliksayisi, DateTime devamsizlikTarihi)
        {
            this.ders = ders;
            this.dersdevamsizliksayisi = dersdevamsizliksayisi;
            this.devamsizlikTarihi = devamsizlikTarihi;
        }
        public void devamsizlikArtir(int adet = 1) {
            dersdevamsizliksayisi = dersdevamsizliksayisi + adet;
        }

    }
}
