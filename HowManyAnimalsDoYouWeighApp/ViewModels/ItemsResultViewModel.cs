using System.Collections.ObjectModel;
using System.ComponentModel;
using HowManyAnimalsDoYouWeighApp.Data.Items;

namespace HowManyAnimalsDoYouWeighApp.ViewModels
{
    public class ItemsResultViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<ItemResultDto> Data { get; set; } = new();
        public ObservableCollection<ItemResultDto> SelectedData { get; set; } = new();
    }
}