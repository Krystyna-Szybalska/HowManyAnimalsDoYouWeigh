using System.Collections.ObjectModel;
using System.ComponentModel;
using HowManyAnimalsDoYouWeighApp.Data.Items;

namespace HowManyAnimalsDoYouWeighApp.ViewModels
{
    public class ItemsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<ItemDto> Data { get; set; } = new();
        public ObservableCollection<ItemDto> SelectedData { get; set; } = new();
    }
}