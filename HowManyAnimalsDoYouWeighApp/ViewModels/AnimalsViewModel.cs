using System.Collections.ObjectModel;
using HowManyAnimalsDoYouWeighApp.Data.Animals;
using HowManyAnimalsDoYouWeighDomain;

namespace HowManyAnimalsDoYouWeighApp.ViewModels
{
    public class AnimalsViewModel
    {
        //what will be seen - so thats animaldto?
        public ObservableCollection<AnimalDto> Data { get; set; } = new();
    }
}