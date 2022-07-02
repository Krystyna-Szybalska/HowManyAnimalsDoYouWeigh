using System;
using System.Collections.Generic;
using HowManyAnimalsDoYouWeighAPI.ItemFunFacts;

namespace HowManyAnimalsDoYouWeighAPI.Items
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public ICollection<ItemFunFact> RandomFacts { get; set; }
    }
}