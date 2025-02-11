namespace OOP_iskolai_adminisztracios_rendszer_BerkiB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            Tantargy tantargy1 = new Tantargy("Matek", r.Next(10, 30));
            Tantargy tantargy2 = new Tantargy("Fizika", r.Next(10, 30));
            Tantargy tantargy3 = new Tantargy("Tesi", r.Next(10, 30));
            Tantargy tantargy4 = new Tantargy("Prog", r.Next(10, 30));
            Tantargy tantargy5 = new Tantargy("Prog2", r.Next(10, 30));
            Tantargy tantargy6 = new Tantargy("AB", r.Next(10, 30)); 
            
            Console.WriteLine(tantargy1.TantargyAdatok());
            Console.WriteLine(tantargy2.TantargyAdatok());
            Console.WriteLine(tantargy3.TantargyAdatok());
            Console.WriteLine(tantargy4.TantargyAdatok());
            Console.WriteLine(tantargy5.TantargyAdatok());
            Console.WriteLine(tantargy6.TantargyAdatok());
            Console.WriteLine();


            Tanar tanar1 = new Tanar("Toth Eva", r.Next(100, 999));
            Tanar tanar2 = new Tanar("Halyagos Mate", r.Next(100, 999));
            Tanar tanar3 = new Tanar("Merenyi Miklos", r.Next(100, 999)); 

            tanar1.HozzaadTantargy(tantargy1);
            tanar1.HozzaadTantargy(tantargy5);
            tanar1.HozzaadTantargy(tantargy6);
            tanar2.HozzaadTantargy(tantargy3);
            tanar2.HozzaadTantargy(tantargy5);
            tanar2.HozzaadTantargy(tantargy4);
            tanar3.HozzaadTantargy(tantargy1);
            tanar3.HozzaadTantargy(tantargy5);
            tanar3.HozzaadTantargy(tantargy2);

            tanar1.OktatottTantargyak();
            Console.WriteLine();
            tanar2.OktatottTantargyak();
            Console.WriteLine();
            tanar3.OktatottTantargyak();
            Console.WriteLine();


            Ertekeles ert = new Ertekeles(new Diak("Wilfredo Rodgers", "11/D", r.Next(1000, 9999)), tantargy1, 5);
            ert.JegyKiiras();
            Console.WriteLine();


            Osztaly osztaly = new Osztaly("11/D", tanar1);

            osztaly.HozzaadDiak(new Diak("Wilfredo Rodgers", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Tania Cannon", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Samantha Crosby", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Erica Lucero", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Maryann Boyer", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Mae Swanson", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Genaro Soto", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Aline Compton", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Sherman Cook", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Eliza Smith", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Irvin Browning", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Dolly Christensen", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Willian Scott", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Tony Mckinney", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Williams Kirk", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Debora Khan", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Stan Frazier", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Deana Herring", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Donna Mccarty", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Madge Rowe", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Greta Bray", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Haley Graham", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Napoleon Macdonald", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Hung Simpson", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Debra Stanton", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Caroline Beard", "11/D", r.Next(1000, 9999)));
            osztaly.HozzaadDiak(new Diak("Tyson Shaw", "11/D", r.Next(1000, 9999)));

            osztaly.OsszesDiakKilistazasa();
            Console.WriteLine();
            osztaly.OsztalyfonokKiirasa();
            Console.WriteLine();



        }
    }
}
