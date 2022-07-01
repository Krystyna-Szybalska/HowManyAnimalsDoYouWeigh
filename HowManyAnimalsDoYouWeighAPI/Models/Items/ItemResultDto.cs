using System.Collections.Generic;
using HowManyAnimalsDoYouWeighAPI.ItemFunFacts;

namespace HowManyAnimalsDoYouWeighAPI.Items
{
    public class ItemResultDto
    {
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public ICollection<ItemFunFactDto> FunFacts { get; set; }
    }
}