using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using HowManyAnimalsDoYouWeighApp.Data.Animals;
using HowManyAnimalsDoYouWeighDomain;

namespace HowManyAnimalsDoYouWeighApp.ViewModels
{
    public class AnimalsViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<AnimalDto> Data { get; set; } = new();
        public ObservableCollection<AnimalDto> SelectedData { get; set; } = new();
        
    }
}