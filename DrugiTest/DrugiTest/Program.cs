﻿using System;
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
            var x1 = context.DOBAVITELJ;
            foreach(var y in x1)
            {
                Console.WriteLine(y.D_IME + " " + y.D_KONTAKT);
            }
            Console.ReadLine();
        }
    }
}
