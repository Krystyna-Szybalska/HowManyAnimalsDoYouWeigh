using System;

namespace HowManyAnimalsDoYouWeighAPI.FunFacts
{
    public class AnimalFunFact
    {
        public Guid Id { get; set; }
        public Guid AnimalId { get; set; }
        public string Text { get; set; }
    }
}