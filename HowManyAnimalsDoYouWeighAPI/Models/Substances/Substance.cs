using System;

namespace HowManyAnimalsDoYouWeighAPI.Items
{
    public class Substance
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Density { get; set; }
        public string RandomFact { get; set; }
    }
}