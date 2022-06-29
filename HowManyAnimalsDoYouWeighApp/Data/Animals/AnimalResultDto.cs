using System.Collections.Generic;
using HowManyAnimalsDoYouWeighApp.Data.AnimalFunFacts;

namespace HowManyAnimalsDoYouWeighApp.Data.Animals
{
    public class AnimalResultDto
    {
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public ICollection<AnimalFunFactDto> FunFacts { get; set; }
    }
}