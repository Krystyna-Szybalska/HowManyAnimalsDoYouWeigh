using System.Collections.ObjectModel;
using HowManyAnimalsDoYouWeighApp.Data.Items;

namespace HowManyAnimalsDoYouWeighApp.ViewModels
{
    public class ItemsResultViewModel
    {
        public ObservableCollection<ItemResultDto> Data { get; set; } = new();
    }
}