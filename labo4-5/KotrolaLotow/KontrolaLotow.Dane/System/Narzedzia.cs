using KontrolaLotow.Dane.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KontrolaLotow.Dane.System
{
    public class Narzedzia
    {
        public static decimal PoliczOdleglosc(Polozenie a, Polozenie b)
        {
            var x = a.X - b.X;
            return x;
        }

        public static int CzasPodrozy()
        {
            var ran = new Random();
             
            return ran.Next();
        }
    }
}
