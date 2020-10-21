using System;
using System.Collections.Generic;
using System.Text;

namespace RobotBuilder.Domain.Entity
{
    public class Robot
    {
        //        W katalogu głównym projektu utwórz nową klasę o nazwie Robot.Ta klasa ma mieć:

        //d.publiczną właściwość string Seria, którego getter zwraca połączony _kodSerii i _nrSerii (np.jeśli _kodSerii = "BB" i _nrSerii = 8, to Seria zwraca wartość "BB-8"
        //i.żeby skleić napis i liczbę, wystarczy użyć operatora +,
        //e.publiczną metodę Uruchom, która zmienia pole _wlaczony na true,
        //f.publiczną metodę DajSygnal, która wyświetla na ekran napis "Sygnał: Wrrrp bleep" tylko gdy pole _wlaczony jest true.

        private string _seriesCode;
        private int _seriesNumber;
        public bool isTurnOn;
        public Robot()
        {

        }
        public string Series
        {
            get
            {
                return _seriesCode + _seriesNumber;
            }
            set
            {

            }
        }
        public Robot(string seriesCode, int seriesNumber)
        {
            _seriesCode = seriesCode;
            _seriesNumber = seriesNumber;
        }
    }
}
