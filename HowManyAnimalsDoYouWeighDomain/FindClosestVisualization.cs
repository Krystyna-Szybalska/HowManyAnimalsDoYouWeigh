using System;
using System.Collections.Generic;
using System.Linq;

namespace HowManyAnimalsDoYouWeighDomain
{
    public class FindClosestVisualization
    {
        public static decimal FindValue(decimal calculatedVolume, List<decimal> availableVisualizations)
        {
            decimal closestVisualization = availableVisualizations.Aggregate((x,y) => Math.Abs(x-calculatedVolume) < Math.Abs(y-calculatedVolume) ? x : y);
            return Math.Round(closestVisualization, 3);
        }
    }
}