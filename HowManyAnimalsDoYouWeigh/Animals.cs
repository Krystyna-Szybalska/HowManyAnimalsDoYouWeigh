using System;
using System.Collections.Generic;
using System.Text;

namespace HowManyAnimalsDoYouWeigh
{
    class Animals
    {
        public static double Ants(double weight)
        {
            double ants = weight * 200000;
            // średnia waga mrówki to 5 mg = 0,005 g = 0,000005 kg
            return ants;
        }
        public static double Chihuahuas(double weight)
        {
            double chihuahuas = weight / 2;
            // średnia waga to 2kg
            return chihuahuas;
        }
        public static double Elephants(double weight)
        {
            double elephants = weight / 5000;
            // średnia waga  to 5000kg
            return elephants;
        }
    }
}
