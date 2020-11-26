using KontrolaLotowLab.Dane.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Szablonowa solucja dla Laboratorium nr 6
//Proszę nie kasować tego komentarza
namespace KontrolaLotowLab.Dane.System
{
    public class SystemKontroliLotow : ISystemKontroliLotow
    {
        private Samolot sledzonySamolot;
        public SystemKontroliLotow()
        {
            Console.WriteLine("System kontroli lotów został uruchomiony.");
        }
        public void ZarejestrujSamolot(Samolot samolot)
        {
            sledzonySamolot = samolot;
            Console.WriteLine("Zrejestrowano {0,10}", sledzonySamolot.Identyfikator);
        }
        public void EkranObecnegoStanu()
        {
            Console.WriteLine("Obecny stan systemu [{0:t}]:", DateTime.Now);
            Console.WriteLine("{0,15} {1,8} {2,10} {3,12} {4,12} {5,10}",
            "Identyfikator", "Typ", "Ładunek", "Wylecial z", "Leci do", "Dotrze o");
            if (sledzonySamolot != null || sledzonySamolot.Pozycja != null)
            {
                Console.WriteLine("{0,15} {1,8:F0} {2,10:F0} {3,12} {4,12} {5,10:t}",
                    sledzonySamolot.Identyfikator,
                    sledzonySamolot.Rodzaj,
                    sledzonySamolot.Ladunek(),
                    sledzonySamolot.MiastoWylot != null ? sledzonySamolot.MiastoWylot.Nazwa : "brak",
                    sledzonySamolot.MiastoCel != null ? sledzonySamolot.MiastoCel.Nazwa : "brak",
                    Narzedzia.SzacujCzasDotarcia(sledzonySamolot)
                    );
            }

        }

        public void PokazWidok()
        {
            //dla testow zadziala to bez wyboru.
            var a = Widok.ListaSamolotow;
            switch (a)
            {
                case 0:
                    EkranObecnegoStanu();
                    break;
                default:
                    break;
            }
        }
    }
}
