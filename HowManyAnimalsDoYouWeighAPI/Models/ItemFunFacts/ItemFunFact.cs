using System;

namespace HowManyAnimalsDoYouWeighAPI.ItemFunFacts
{
    public class ItemFunFact
    {
        public Guid Id { get; set; }
        public Guid ItemId { get; set; }
        public string Text { get; set; }
    }
}