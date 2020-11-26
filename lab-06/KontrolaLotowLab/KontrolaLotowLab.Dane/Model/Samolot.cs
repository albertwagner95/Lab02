using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Szablonowa solucja dla Laboratorium nr 6
//Proszę nie kasować tego komentarza
namespace KontrolaLotowLab.Dane.Model
{
    public abstract class Samolot
    {
        public double Predkosc { get; set; }
        /*
            * Standardowe samoloty pasażerskie latają z prędkością 800–1000 km/h (220–280 m/s)
            */
        public string Identyfikator { get; private set; }
        public abstract string Rodzaj { get; }
        public Polozenie Pozycja { get; private set; }
        public Miasto MiastoWylot { get; set; }
        public Miasto MiastoCel { get; set; }
        public Samolot(string identyfikator, Polozenie polozenie)
        {
            Identyfikator = identyfikator;
            Pozycja = polozenie;
        }

        public Samolot(string identyfikator, double predkosc)
        {
            Identyfikator = identyfikator;
            Predkosc = predkosc;
        }

        public Samolot(string identyfikator, double predkosc, Miasto miastoWylotu)
        {
            Identyfikator = identyfikator;
            Predkosc = predkosc;
            MiastoWylot = miastoWylotu;
            Pozycja = new Polozenie(miastoWylotu.PolozenieM.X, miastoWylotu.PolozenieM.Y);
        }

        public abstract string Ladunek();

    }
}
