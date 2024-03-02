using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoklamaTutucu.models
{
    public class Dersdevamsizlik
    {
        public Ders ders { get; set; }

        public int dersDevamsizlikSayisi { get; set; }

        public DateTime devamsizlikTarihi { get; set;}
        public Dersdevamsizlik(Ders ders,int dersdevamsizliksayisi, DateTime devamsizlikTarihi)
        {
            this.ders = ders;
            this.devamsizlikTarihi = devamsizlikTarihi;
            this.dersDevamsizlikSayisi = dersdevamsizliksayisi;
        }
        public void devamsizlikArtir(int adet = 1)
        {
            dersDevamsizlikSayisi = dersDevamsizlikSayisi + adet;
        }


    }
}
