using System.Collections.ObjectModel;
using HowManyAnimalsDoYouWeighApp.Data.Items;

namespace HowManyAnimalsDoYouWeighApp.ViewModels
{
    public class ItemsViewModel
    {
        public ObservableCollection<ItemDto> Data { get; set; } = new();

    }
}