using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_iskolai_adminisztracios_rendszer_BerkiB
{
    internal class Tanar
    {
        private string nev;
        private List<Tantargy> tantargyak;
        private int tanatID;

        public Tanar(string nev, int tanatID)
        {
            this.nev = nev;
            this.tantargyak = new List<Tantargy>();
            this.tanatID = tanatID;
        }

        public void HozzaadTantargy(Tantargy tantargy)
        {
            this.tantargyak.Add(tantargy);
        }

        public void OktatottTantargyak()
        {
            foreach (var item in this.tantargyak)
            {
                Console.WriteLine(item.TantargyAdatok());
            }
        }

        public override string ToString()
        {
            return this.nev;
        }

    }
}
