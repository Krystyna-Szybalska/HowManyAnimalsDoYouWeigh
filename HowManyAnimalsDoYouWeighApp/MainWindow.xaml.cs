using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using HowManyAnimalsDoYouWeighApp.Data.Animals;
using HowManyAnimalsDoYouWeighApp.Data.Items;
using HowManyAnimalsDoYouWeighApp.Data.Substances;
using HowManyAnimalsDoYouWeighApp.Services;
using HowManyAnimalsDoYouWeighApp.ViewModels;
using HowManyAnimalsDoYouWeighDomain;

namespace HowManyAnimalsDoYouWeighApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainViewModel MainViewModel { get; set; } = new();
        public Client Client { get; set; } = new();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = MainViewModel;
            Loaded += OnLoaded;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e) {
            foreach (var animal in await Client.GetAnimalsAsync())
            {
                MainViewModel.Animals.Data.Add(animal);
            }

            foreach (var item in await Client.GetItemsAsync())
            {
                MainViewModel.Items.Data.Add(item);
            }

            foreach (var substance in await Client.GetSubstancesAsync())
            {
                MainViewModel.Substances.Data.Add(substance);
            }
        }
        
        
        private void ActiveListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AnimalsListView is not null) {
                AnimalsListView.Visibility = MainViewModel.ActiveListView == ListViewName.Animals
                    ? Visibility.Visible
                    : Visibility.Collapsed;
            }

            if (SubstancesListView is not null) {
                SubstancesListView.Visibility = MainViewModel.ActiveListView == ListViewName.Substances
                    ? Visibility.Visible
                    : Visibility.Collapsed;
            }

            if (ItemsListView is not null) {
                ItemsListView.Visibility = MainViewModel.ActiveListView == ListViewName.Items
                    ? Visibility.Visible
                    : Visibility.Collapsed;
            }
        }

        private void SearchTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var text = SearchTextBox.Text;

            if (text.Length is < 3 and > 0) return;

            switch (MainViewModel.ActiveListView)
            {
                case ListViewName.Animals:
                    if (text.Length == 0)
                    {
                        AnimalsListView.ItemsSource = MainViewModel.Animals.Data; //dlaczego nie mogę tego uwzględnić wyżej?
                    }
                    else
                    {
                        var foundAnimals = MainViewModel.Animals.Data.Where(a =>
                            a.Name is not null && a.Name.Contains(text, StringComparison.CurrentCultureIgnoreCase)).ToList();
                        AnimalsListView.ItemsSource = foundAnimals;
                    }

                    break;
                
                case ListViewName.Substances:
                    if (text.Length == 0)
                    {
                        SubstancesListView.ItemsSource = MainViewModel.Substances.Data; //dlaczego nie mogę tego uwzględnić wyżej?
                    }
                    else
                    {
                        var foundSubstances = MainViewModel.Substances.Data.Where(a =>
                            a.Name is not null && a.Name.Contains(text, StringComparison.CurrentCultureIgnoreCase)).ToList();
                        SubstancesListView.ItemsSource = foundSubstances;
                    }

                    break;
                
                case ListViewName.Items:
                    if (text.Length == 0)
                    {
                        ItemsListView.ItemsSource = MainViewModel.Items.Data; //dlaczego nie mogę tego uwzględnić wyżej?
                    }
                    else
                    {
                        var foundItems = MainViewModel.Items.Data.Where(a =>
                            a.Name is not null && a.Name.Contains(text, StringComparison.CurrentCultureIgnoreCase)).ToList();
                        ItemsListView.ItemsSource = foundItems;
                    }

                    break;
            }
        }

        private async void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            // jeśli wpisana wartość jest niepoprawna - ma wyświetlić komunikat o błędzie
            if (!decimal.TryParse(inputWeight.Text, out var weight))
            {
                ErrorMessage.Visibility = Visibility.Visible;
                ErrorMessage.Text = "Type in a valid number";
                inputWeight.Text = null;
                ErrorMessage.FontStyle = FontStyles.Italic;
            }

            else
            {
                SelectedTextBlock.Text = String.Empty;

                // jeśli podane jest w lbs - ma przeliczyć na kg
                if (combobox.SelectedIndex == 1)
                {
                    weight = ConvertWeight.LbsToKg(weight);
                }
                
                //zrobić funkcję która aktywuje dobre rzeczy w result window na podstawie rzeczy aktywnych tutaj
                MainResultViewModel mainResultViewModel = new MainResultViewModel();
                switch (SelectedTypeCombobox.Text)
                {
                    case "Animal":
                        mainResultViewModel.AnimalsResult.Data = await GetAnimalResult(); 
                        break;
                    case "Item":
                        mainResultViewModel.ItemsResult.Data = await GetItemResult(); 
                        break;
                    case "Substance":
                        mainResultViewModel.SubstanesResult.Data = await GetSubstancesResult(); 
                    break;
                }
               // ResultWindow resultWindow = new ResultWindow(mainResultViewModel);
               // resultWindow.Show();
            }

        }

        private async Task<ObservableCollection<AnimalResultDto>> GetAnimalResult()
        {
            var fullResults = await Client.GetAnimalResultAsync(); //TODO: pobierać tylko to co trzeba
            var listResults = fullResults.Where(a => MainViewModel.Animals.SelectedData.Any(x => x.Name == a.Name))
                .ToList();
            ObservableCollection<AnimalResultDto> finalResults = new ObservableCollection<AnimalResultDto>(listResults);

            return finalResults;
        }
        
        private async Task<List<ItemResultDto>> GetItemResult()
        {
            var fullResults = await Client.GetItemResultAsync(); //TODO: pobierać tylko to co trzeba
            var listResults = fullResults.Where(a => MainViewModel.Items.SelectedData.Any(x => x.Name == a.Name))
                .ToList();
            ObservableCollection<ItemResultDto> finalResults = new ObservableCollection<ItemResultDto>(listResults);

            return finalResults;
        }
        private async Task<List<SubstanceResultDto>> GetSubstanceResult()
        {
            var fullResults = await Client.GetSubstanceResultAsync(); //TODO: pobierać tylko to co trzeba
            var listResults = fullResults.Where(a => MainViewModel.Substances.SelectedData.Any(x => x.Name == a.Name))
                .ToList();
            ObservableCollection<SubstanceResultDto> finalResults = new ObservableCollection<SubstanceResultDto>(listResults);

            return finalResults;
        }

        private void AnimalsListView_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainViewModel.Animals.SelectedData.Add((AnimalDto) AnimalsListView.SelectedItem);
            SelectedTextBlock.Text = String.Join("\n",MainViewModel.Animals.SelectedData.Select(a => a.Name)); //ładniejsze wyświetlanie
        }
        
        private void ItemsListView_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainViewModel.Items.SelectedData.Add((ItemDto) ItemsListView.SelectedItem);
            SelectedTextBlock.Text = String.Join("\n",MainViewModel.Items.SelectedData.Select(a => a.Name)); //ładniejsze wyświetlanie
        }
        
        private void SubstancesListView_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainViewModel.Substances.SelectedData.Add((SubstanceDto) SubstancesListView.SelectedItem);
            SelectedTextBlock.Text = String.Join("\n",MainViewModel.Substances.SelectedData.Select(a => a.Name)); //ładniejsze wyświetlanie
        }
    }
}
