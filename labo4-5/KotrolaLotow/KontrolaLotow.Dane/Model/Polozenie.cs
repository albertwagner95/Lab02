using System;
using System.Collections.Generic;
using System.Text;

namespace KontrolaLotow.Dane.Model
{
    public class Polozenie
    {
        public decimal X { get; private set; }
        public decimal Y { get; private set; }

        public Polozenie(decimal x,decimal y)
        {
            X = x;
            Y = y;
        }

        public void Zmien(decimal xx, decimal yY)
        {
            X = xx;
            Y = yY;
        }

    }
}
