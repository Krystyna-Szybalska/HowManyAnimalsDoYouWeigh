using System.Collections.ObjectModel;
using HowManyAnimalsDoYouWeighApp.Data.Animals;

namespace HowManyAnimalsDoYouWeighApp.ViewModels
{
    public class AnimalsResultViewModel
    {
        public ObservableCollection<AnimalResultDto> Data { get; set; } = new();
    }
}