using System.Collections.ObjectModel;
using HowManyAnimalsDoYouWeighApp.Data.Substances;

namespace HowManyAnimalsDoYouWeighApp.ViewModels
{
    public class SubstancesViewModel
    {
        public ObservableCollection<SubstanceDto> Data { get; set; } = new();
    }
}