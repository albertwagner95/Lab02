using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolaLotowLab.Dane.Model
{
    public class SamolotPasazerski : Samolot
    {
        public int IloscMiejsc { get; protected set; }
        public override string Rodzaj { get { return "P"; } }
        public int IlosPasazerow { get; set; }

        public SamolotPasazerski(string identyfikator, double predkosc, int iloscMiejsc) : base(identyfikator, predkosc)
        {
            IloscMiejsc = iloscMiejsc;
        }

        public override string Ladunek()
        {

            return $"{IlosPasazerow}/{IloscMiejsc}";
        }

    }
}
