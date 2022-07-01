using System;
using System.Collections.Generic;
using HowManyAnimalsDoYouWeighApp.Data.ItemFunFacts;

namespace HowManyAnimalsDoYouWeighApp.Data.Items
{
    public class ItemResultDto
    {
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public List<ItemFunFactDto> FunFacts { get; set; }
        public decimal CalculatedAmount { get; set; }
        public string RandomFact => FunFacts[new Random().Next(0,FunFacts.Count)].Text;
    }
}