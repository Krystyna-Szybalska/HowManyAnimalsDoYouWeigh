using System.Collections.ObjectModel;
using System.ComponentModel;
using HowManyAnimalsDoYouWeighApp.Data.Substances;

namespace HowManyAnimalsDoYouWeighApp.ViewModels
{
    public class SubstancesResultViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<SubstanceResultDto> Data { get; set; } = new();
        public ObservableCollection<SubstanceResultDto> SelectedData { get; set; } = new();
    }
}