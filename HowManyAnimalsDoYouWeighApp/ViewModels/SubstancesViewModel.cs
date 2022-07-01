using System.Collections.ObjectModel;
using System.ComponentModel;
using HowManyAnimalsDoYouWeighApp.Data.Substances;

namespace HowManyAnimalsDoYouWeighApp.ViewModels
{
    public class SubstancesViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<SubstanceDto> Data { get; set; } = new();
        public ObservableCollection<SubstanceDto> SelectedData { get; set; } = new();
    }
}