using System;
using System.Collections.Generic;
using System.Text;

namespace HowManyAnimalsDoYouWeighDomain
{
    public class WeightAndVolumeConverters
    {
        public static decimal LbsToKg(decimal weightInLbs)
        {
            decimal weightInKg = weightInLbs * 0.45359237m;
            return weightInKg;
        }
        
        public static decimal KgToAnimal(decimal weightInKg, decimal animalWeight)
        {
            decimal weightInAnimal = weightInKg / animalWeight;
            return weightInAnimal;
        }
        public static decimal KgToItem(decimal weightInKg, decimal itemWeight)
        {
            decimal weightInItem = weightInKg / itemWeight;
            return weightInItem;
        }
        public static decimal KgToSubstanceVolume(decimal weightInKg, decimal substanceDensity)
        {
            decimal volumeInLiters =  substanceDensity/weightInKg;
            return volumeInLiters;
        }

        public static string FindClosestVisualization(decimal calculatedVolume)
        {
            throw new NotImplementedException();
        }
        
    }
}
