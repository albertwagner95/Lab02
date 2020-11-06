using KontrolaLotow.Dane.Baza;
using KontrolaLotow.Dane.Model;
using KontrolaLotow.Dane.System;
using System;
using System.Runtime.InteropServices.ComTypes;

namespace KotrolaLotow
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sysK = new SystemKontroliLotow();
            //var rep = new Repozytorium();

            //var sam = rep.WezSamolot();
            //sysK.WezSamolot(sam);

            //sysK.EkranObecnegoStanu();

            var sysK = new SystemKontroliLotow();
            var rep = new Repozytorium();
            var mias = rep.WezMiasto("Kraków");
            var samolot = new Samolot(12, 22, mias);
            var sam = rep.WezSamolot();
            sysK.EkranObecnegoStanu();
        }
    }
}
