using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoklamaTutucu.models
{
    public  class Ders
    {
        public string adi;
        public string hocasi;

        public Ders(string adi, string hocasi)
        {
            this.adi = adi;
            this.hocasi = hocasi;
        }
    }
}
