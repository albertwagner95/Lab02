using KontrolaLotowLab.Dane.Baza;
using KontrolaLotowLab.Dane.Model;
using KontrolaLotowLab.Dane.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Szablonowa solucja dla Laboratorium nr 6
//Proszę nie kasować tego komentarza
namespace KontrolaLotowLab.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            
            var systemKontroliLotow = new SystemKontroliLotow();
            var repozytorium = new Repozytorium();
            var miastoGdansk = repozytorium.WezMiasto("Gdańsk");
            var miastoNowyJork = repozytorium.WezMiasto("Nowy Jork");
            var samolot = repozytorium.WezSamolot(miastoGdansk, 200, 140);
            samolot.MiastoCel = miastoNowyJork;
            systemKontroliLotow.ZarejestrujSamolot(samolot);
            systemKontroliLotow.PokazWidok();
            var drugiSamolot = repozytorium.WezSamolot(repozytorium.WezMiasto("New York"), 3000, 2500);
            drugiSamolot.MiastoCel = miastoGdansk;
            systemKontroliLotow.ZarejestrujSamolot(drugiSamolot);
            systemKontroliLotow.PokazWidok();


            Console.ReadKey();
        }
    }
}
