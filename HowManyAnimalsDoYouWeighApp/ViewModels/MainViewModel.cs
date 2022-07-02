using System.ComponentModel;

namespace HowManyAnimalsDoYouWeighApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
       
        public AnimalsViewModel Animals { get; set; } = new();
        public ItemsViewModel Items { get; set; } = new();
        public SubstancesViewModel Substances { get; set; } = new();
        public string ActiveListView { get; set; } = ListViewName.Animals;

    }
}