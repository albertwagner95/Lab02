using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Szablonowa solucja dla Laboratorium nr 6
//Proszę nie kasować tego komentarza
namespace KontrolaLotowLab.Dane.Model
{
    public class Polozenie
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public Polozenie(double x,double y)
        {
            X = x;
            Y = y;
        }
        public void Zmien(double x,double y)
        {
            X = x;
            Y = y;
        }

    }
}
