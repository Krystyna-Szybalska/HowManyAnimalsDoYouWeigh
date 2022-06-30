using System;
using System.Collections.Generic;
using System.Text;

namespace HowManyAnimalsDoYouWeighDomain
{
    public class UnitConverter
    {
        public static decimal ConvertLbsToKg(decimal weightInLbs)
        {
            decimal weightInKg = weightInLbs * 0.45359237m;

            return weightInKg;
        }
    }
}
