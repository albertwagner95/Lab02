using KontrolaLotowLab.Dane.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

//Szablonowa solucja dla Laboratorium nr 6
//Proszę nie kasować tego komentarza
namespace KontrolaLotowLab.Dane.System
{
    public class Narzedzia
    {
        public static double PoliczOdleglosc(Polozenie a, Polozenie b)
        {
            //TODO
            try
            {
                var punktA = new GeoCoordinate(a.X, a.Y);
                var punktB = new GeoCoordinate(b.X, b.Y);
                var odleglosc = punktA.GetDistanceTo(punktB);
                return odleglosc / 1000;

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public static DateTime SzacujCzasDotarcia(Samolot samolot)
        {
            // TO DO
            //t=s/v   np. t = 10km/30km/h =0,3h 0,3/60 = minuty ->min na godziny dt.now + godziny
            //czas wylotu obrałem "now";
            try
            {
                var kilometers = PoliczOdleglosc(samolot.MiastoWylot.PolozenieM, samolot.MiastoCel.PolozenieM);
                var hours = kilometers / samolot.Predkosc;
                DateTime przewidywanyCzas = DateTime.Now.AddHours(hours);
                return przewidywanyCzas;

            }
            catch (Exception)
            {

                return DateTime.Now;
            }


        }
    }
}
