namespace HowManyAnimalsDoYouWeighApp.ViewModels
{
    public class MainResultViewModel
    {
        public SubstancesResultViewModel SubstancesResult { get; set; } = new();
        public ItemsResultViewModel ItemsResult { get; set; } = new();
        public AnimalsResultViewModel AnimalsResult { get; set; } = new();
    }
}