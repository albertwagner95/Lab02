using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolaLotowLab.Dane.Model
{
    public class SamolotTowarowy : Samolot
    {
        public decimal WagaLadunku { get; set; }
        public decimal MaksymalnaWaga { get; protected set; }

        public override string Rodzaj
        {
            get { return "T"; }
        }

        public SamolotTowarowy(decimal maksymalnaWaga, string identyfikator, double predkosc, Miasto miastoWylotu) : base(identyfikator, predkosc, miastoWylotu)
        {
            MaksymalnaWaga = maksymalnaWaga;
        }

        public override string Ladunek()
        {
            return $"{WagaLadunku}/{MaksymalnaWaga}";
        }
    }
}
