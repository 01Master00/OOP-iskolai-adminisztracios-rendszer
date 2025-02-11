using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_iskolai_adminisztracios_rendszer_BerkiB
{
    internal class Diak
    {
        private string nev;
        private string osztaly;
        private int azonosto;

        public Diak(string nev, string osztaly, int azonosto)
        {
            this.nev = nev;
            this.osztaly = osztaly;
            this.azonosto = azonosto;
        }

        public string TeljesNevKiiras()
        {
            return $"{this.nev}, {this.osztaly}";
        }

        public override string ToString()
        {
            return this.nev;
        }
    }
}
