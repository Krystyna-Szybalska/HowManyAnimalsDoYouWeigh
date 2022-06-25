using System.Collections.Generic;
using HowManyAnimalsDoYouWeighAPI.FunFacts;

namespace HowManyAnimalsDoYouWeighAPI
{
    public class AnimalResultDto
    {
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public ICollection<AnimalFunFactDto> FunFacts { get; set; }
    }
}