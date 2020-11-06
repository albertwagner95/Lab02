using KontrolaLotow.Dane.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KontrolaLotow.Dane.Baza
{
    public class Repozytorium
    {
        public Miasto WezMiasto(string miastoN)
        {
            var random = new Random();
            var polozenie = new Polozenie(random.Next(), random.Next());
            var miasto = new Miasto()
            {
                Nazwa = miastoN,
                PolozenieM = polozenie
            };
             
            return miasto;
        }

        public Samolot WezSamolot()
        {
            return new Samolot(94124,new Polozenie(131, 2225));
        }
    }
}

