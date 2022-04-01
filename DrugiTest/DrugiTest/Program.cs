using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BazaZaVajeEntities context = new BazaZaVajeEntities();
            //vsi dobavitelji
            //var x1 = from a in context.DOBAVITELJ
            //         select a;



            //DateTime datum = DateTime.Parse("20.1.2004");
            //var x2 = from a in context.PRODUKT
            //         where a.P_DATUM < datum
            //         select new { Opis = a.P_OPIS, Zaloga = a.P_ZALOGA, MinZaloga = a.P_ZALOGA, Cena = a.P_CENA };
            //foreach(var y in x2)
            //{
            //    Console.WriteLine(y.Opis + " " + y.Cena);
            //}

            //DateTime danes = DateTime.Today;
            //var x3 = from a in context.PRODUKT
            //         select new {Opis = a.P_OPIS, Zaloga = a.P_ZALOGA, MinZaloga = a.P_ZALOGA, Cena = a.P_CENA, Zapadlost = danes };



            //var x4 = from a in context.DOBAVITELJ
            //         where a.D_KONTAKT.StartsWith("Smith")
            //         select a;
            //foreach(var y in x4)
            //{
            //    Console.WriteLine();
            //}



            //var x5 = (from a in context.DOBAVITELJ
            //          select a.D_KODA).Distinct();

            //foreach (var y in x5)
            //{
            //    Console.WriteLine(y);
            //}


            //var x6 = context.DOBAVITELJ.Where(e => !x5.Any(p => p == e.D_KODA));
            //foreach(var y in x6)
            //{
            //    Console.WriteLine(y.D_KODA);
            //}


            var x7 = context.KUPEC.Sum(e => e.KUP_STANJE);
            var x8 = (from a in context.KUPEC
                      select a.KUP_STANJE).Sum();
            Console.WriteLine("prvi rez " + x7);
            Console.WriteLine("drugi rez " + x8);

            Console.ReadLine();
        }
    }
}
