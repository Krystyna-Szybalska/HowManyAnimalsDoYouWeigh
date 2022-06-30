using HowManyAnimalsDoYouWeighDomain;

namespace HowManyAnimalsDoYouWeighApp.ViewModels
{
    public class MainViewModel
    {
        //animals view model etc - jeden na głównej stronie, jeden na stronie wynikow
        
        public AnimalsResultViewModel AnimalsResult { get; set; } = new();
        public AnimalsViewModel Animals { get; set; } = new();
        public ItemsResultViewModel ItemsResult { get; set; } = new();
        public ItemsViewModel Items { get; set; } = new();
        public SubstancesResultViewModel SubstancesResult { get; set; } = new();
        public SubstancesViewModel Substances { get; set; } = new();
        public string ActiveListView { get; set; } = ListViewName.Animals;
    }
}