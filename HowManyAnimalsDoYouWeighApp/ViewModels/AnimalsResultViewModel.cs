using System.Collections.ObjectModel;
using System.ComponentModel;
using HowManyAnimalsDoYouWeighApp.Data.Animals;

namespace HowManyAnimalsDoYouWeighApp.ViewModels
{
    public class AnimalsResultViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<AnimalResultDto> Data { get; set; } = new();
    }
}