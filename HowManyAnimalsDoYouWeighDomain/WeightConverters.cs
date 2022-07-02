using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HowManyAnimalsDoYouWeighDomain
{
    public class WeightConverters
    {
        public static decimal LbsToKg(decimal weightInLbs)
        {
            decimal weightInKg = weightInLbs * 0.45359237m;
            return weightInKg;
        }
        
        public static string KgToAnimal(decimal weightInKg, decimal animalWeight)
        {
            decimal weightInAnimal = weightInKg / animalWeight;
            return ToScientificNotation(weightInAnimal);
        }
        public static string KgToItem(decimal weightInKg, decimal itemWeight)
        {
            decimal weightInItem = weightInKg / itemWeight;
            return ToScientificNotation(weightInItem);
        }
        public static decimal KgToSubstanceVolume(decimal weightInKg, decimal substanceDensity)
        {
            decimal volumeInLiters =  substanceDensity/weightInKg;
            return volumeInLiters;
        }

        public static string ToScientificNotation(decimal number) {
            return number.ToString("G4", CultureInfo.InvariantCulture);
        }
    }
}
