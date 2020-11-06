using System;
using System.Collections.Generic;
using System.Text;

namespace KontrolaLotow.Dane.Model
{
    public class Samolot
    {
        public int Id { get; set; }
        public decimal Predkosc { get; set; }

        public Polozenie Pozycja { get; private set; }
        public Miasto MiastoWylot { get; set; }
        public Miasto MiastoWyCel { get; set; }

        public Samolot(int id, Polozenie polozenie)
        {
            Id = id;
            Pozycja = polozenie;
        }
        public Samolot(int id, decimal predkosc)
        {
            Id = id;
            Predkosc = predkosc;
        }
        public Samolot(int id, decimal predkosc, Miasto miastoWylot)
        {
            Id = id;
            Predkosc = predkosc;
            Pozycja = new Polozenie(miastoWylot.PolozenieM.X, miastoWylot.PolozenieM.Y);
        }
    }
}
