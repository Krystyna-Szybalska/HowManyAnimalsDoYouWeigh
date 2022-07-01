using System.Collections.ObjectModel;
using System.ComponentModel;
using HowManyAnimalsDoYouWeighApp.Data.Visualizations;

namespace HowManyAnimalsDoYouWeighApp.ViewModels
{
    public class VisualizationsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<VisualizationDto> Data { get; set; } = new();
        public ObservableCollection<VisualizationDto> SelectedData { get; set; } = new();
    }
}