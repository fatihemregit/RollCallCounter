using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoklamaTutucu.models
{
    public class Ders
    {
        private string adi { get; set; }
        private string hocasi { get; set;}

        private int dersdevamsizliksayisi { get; set; } = 0;

        public Ders(string adi, string hocasi, int dersdevamsizliksayisi)
        {
            this.adi = adi;
            this.hocasi = hocasi;
            this.dersdevamsizliksayisi = dersdevamsizliksayisi;
        }
    }
}
