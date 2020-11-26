using KontrolaLotowLab.Dane.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Szablonowa solucja dla Laboratorium nr 6
//Proszę nie kasować tego komentarza
namespace KontrolaLotowLab.Dane.Baza
{
    public class Repozytorium
    {
        public Miasto WezMiasto()
        {
            Miasto miasto = new Miasto()
            {
                Nazwa = "Londyn",
                PolozenieM = new Polozenie(131/100.0, 2255/100.0)
            };
            return miasto;
        }
        public Miasto WezMiasto(string nazwaMiasta)
        {
            //TODO
            var random = new Random();
            double a1 = random.Next(-90+nazwaMiasta.Length,90-nazwaMiasta.Length);
            double b1 = random.Next(-90 + nazwaMiasta.Length, 90 - nazwaMiasta.Length); //to losowanie współrzędnych jest dla testów
            Miasto miasto = new Miasto()
            {
                Nazwa = nazwaMiasta,//tu
                PolozenieM = new Polozenie(a1, b1)
            };
            return miasto;
        }
        //public Samolot WezSamolot()
        //{
        //    Samolot samolot = new Samolot("Lot 94124", new Polozenie(131/100.0, 2255/100.0));
        //    return samolot;
        //}
        //public Samolot WezSamolot(Miasto miastoWylotu)
        //{
        //    Samolot samolot = new Samolot("Lot 23513", 900, miastoWylotu);
        //    return samolot;
        //}
        public Samolot WezSamolot(int iloscMiejsc, int iloscPasazerow)
        {
            var samolot = new SamolotPasazerski("Lot33441", 870.0, iloscMiejsc);
            samolot.IlosPasazerow = iloscPasazerow;
            return samolot;
        }
        public Samolot WezSamolot(Miasto miastoWylotu, decimal maksymalnaWaga, decimal wagaLadunku)
        {
            var samolotTowarowy = new SamolotTowarowy(maksymalnaWaga, "Lot51314", 680.0, miastoWylotu);
            samolotTowarowy.WagaLadunku = wagaLadunku;
            return samolotTowarowy;
        }
    }
}
