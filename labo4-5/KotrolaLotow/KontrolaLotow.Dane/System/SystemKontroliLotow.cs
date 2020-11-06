using KontrolaLotow.Dane.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KontrolaLotow.Dane.System
{
    public class SystemKontroliLotow
    {
        private Samolot _sledzonySamolot;
        public void WezSamolot(Samolot samolot)
        {
                _sledzonySamolot = samolot;
            Console.WriteLine($"Zarejestrowano {samolot.Id}:");
        }
        public Samolot WezSamolot(Miasto miastoWylotu)
        {
            return new Samolot(23513, 900, miastoWylotu);
        }
        public SystemKontroliLotow()
        { 

            Console.WriteLine("System kontroli lotów został uruchomiony");
        }
        public  void EkranObecnegoStanu()
        {
            if (_sledzonySamolot.MiastoWyCel != null &&
                _sledzonySamolot.MiastoWylot != null &&
                _sledzonySamolot.Id != 0 &&
                _sledzonySamolot.Pozycja != null)
            {
                Console.WriteLine("Obecny stan systemu [{0:t}]:", DateTime.Now);
                Console.WriteLine("{0,15} {1,8} {2,8} {3,12} {4,12} {5,10}",
               $"{_sledzonySamolot.Id}", $"{_sledzonySamolot.Pozycja.X}", $"{_sledzonySamolot.Pozycja.Y}", $"Wylecial z {_sledzonySamolot.MiastoWylot}", $"Leci do {_sledzonySamolot.MiastoWyCel}", "Dotrze o");
                Console.WriteLine("{0,15} {1,8} {2,8} {3,12} {4,12} {5,10}",
                    Narzedzia.CzasPodrozy(),
                    Narzedzia.CzasPodrozy(),
                    Narzedzia.CzasPodrozy(),
                    Narzedzia.CzasPodrozy(),
                    Narzedzia.CzasPodrozy(),
                    Narzedzia.CzasPodrozy());
            }
            else
            {
                Console.WriteLine("brak danych");
                Console.WriteLine("brak danych");
            }
        }


    }
}
