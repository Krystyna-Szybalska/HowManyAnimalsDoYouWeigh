using System;
using System.Collections.Generic;
using HowManyAnimalsDoYouWeighAPI.FunFacts;

namespace HowManyAnimalsDoYouWeighAPI
{
    public class Animal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public ICollection<AnimalFunFact> FunFacts { get; set; }
    }
}