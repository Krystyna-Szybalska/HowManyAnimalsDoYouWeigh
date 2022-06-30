using System.Collections.ObjectModel;
using HowManyAnimalsDoYouWeighApp.Data.Visualizations;

namespace HowManyAnimalsDoYouWeighApp.ViewModels
{
    public class VisualizationsViewModel
    {
        public ObservableCollection<VisualizationDto> Data { get; set; } = new();

    }
}