using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_iskolai_adminisztracios_rendszer_BerkiB
{
    internal class Tantargy
    {
        private string nev;
        private int kontaktOrak;

        public Tantargy(string nev, int kontaktOrak)
        {
            this.nev = nev;
            this.kontaktOrak = kontaktOrak;
        }

        public string TantargyAdatok()
        {
            return $"{this.nev}: {this.kontaktOrak}";
        }

        public override string ToString()
        {
            return this.nev;
        }
    }
}
