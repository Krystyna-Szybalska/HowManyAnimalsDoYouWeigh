using System;
using System.Collections.Generic;
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
        
        public static decimal KgToAnimal(decimal weightInKg, decimal animalWeight)
        {
            decimal weightInAnimal = weightInKg / animalWeight;
            return Math.Round(weightInAnimal, 3);
        }
        public static decimal KgToItem(decimal weightInKg, decimal itemWeight)
        {
            decimal weightInItem = weightInKg / itemWeight;
            return Math.Round(weightInItem, 3);
        }
        public static decimal KgToSubstanceVolume(decimal weightInKg, decimal substanceDensity)
        {
            decimal volumeInLiters =  substanceDensity/weightInKg;
            return Math.Round(volumeInLiters, 3);
        }
    }
}
