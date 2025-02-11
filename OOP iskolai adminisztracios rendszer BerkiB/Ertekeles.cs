using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_iskolai_adminisztracios_rendszer_BerkiB
{
    internal class Ertekeles
    {
        Diak diak;
        Tantargy tantargy;
        int erdemjegy;

        public Ertekeles(Diak diak, Tantargy tantargy, int erdemjegy)
        {
            this.diak = diak;
            this.tantargy = tantargy;
            this.erdemjegy = erdemjegy;
        }

        public void JegyKiiras()
        {
            Console.WriteLine(this.tantargy);
            Console.WriteLine(this.erdemjegy);
        }


    }
}
