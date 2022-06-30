using System.Collections.ObjectModel;
using HowManyAnimalsDoYouWeighApp.Data.Substances;

namespace HowManyAnimalsDoYouWeighApp.ViewModels
{
    public class SubstancesResultViewModel
    {
        public ObservableCollection<SubstanceResultDto> Data { get; set; } = new();
    }
}