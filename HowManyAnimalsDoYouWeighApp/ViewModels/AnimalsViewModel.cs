using System.Collections.ObjectModel;
using System.ComponentModel;
using HowManyAnimalsDoYouWeighApp.Data.Animals;

namespace HowManyAnimalsDoYouWeighApp.ViewModels
{
    public class AnimalsViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<AnimalDto> Data { get; set; } = new();
        public ObservableCollection<AnimalDto> SelectedData { get; set; } = new();
        
    }
}