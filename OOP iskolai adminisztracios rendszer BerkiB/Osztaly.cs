using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_iskolai_adminisztracios_rendszer_BerkiB
{
    internal class Osztaly
    {
        private string nev;
        List<Diak> diakok;
        Tanar osztalyfonok;

        public Osztaly(string nev, Tanar osztalyfonok)
        {
            this.nev = nev;
            this.diakok = new List<Diak>();
            this.osztalyfonok = osztalyfonok;
        }

        public void HozzaadDiak(Diak diak)
        {
            if (this.diakok.Count() <= 25)
            {
                this.diakok.Add(diak);
            }
            else
            {
                Console.WriteLine("A létszám túllépte a maxiumot(25)");
            }
        }


        public void OsszesDiakKilistazasa()
        {
            foreach (var item in this.diakok)
            {
                Console.WriteLine(item);
            }
        }

        public void OsztalyfonokKiirasa()
        {
            Console.WriteLine(this.osztalyfonok);
            this.osztalyfonok.OktatottTantargyak();
        }
    }
}
