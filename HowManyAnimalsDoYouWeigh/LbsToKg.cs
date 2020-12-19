using System;
using System.Collections.Generic;
using System.Text;

namespace HowManyAnimalsDoYouWeigh
{
    class LbsToKg
    {
        public static double ConvertToKg(double weightInLbs)
        {
            double weightInKg = weightInLbs * 0.45359237;

            return weightInKg;
        }
    }
}
