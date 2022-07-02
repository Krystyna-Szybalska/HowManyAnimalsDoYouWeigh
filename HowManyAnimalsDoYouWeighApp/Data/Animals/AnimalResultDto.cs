using System;
using System.Collections.Generic;
using HowManyAnimalsDoYouWeighApp.Data.AnimalFunFacts;

namespace HowManyAnimalsDoYouWeighApp.Data.Animals
{
    public class AnimalResultDto
    {
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public List<AnimalFunFactDto> FunFacts { get; set; }
        public string CalculatedAmount { get; set; }
        public string RandomFact => FunFacts[new Random().Next(0, FunFacts.Count)].Text;
    }
}