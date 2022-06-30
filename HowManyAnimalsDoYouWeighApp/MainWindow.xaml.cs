using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
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
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = MainViewModel;
        }
        private void CurrentSection_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
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

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            // jeśli wpisana wartość jest niepoprawna - ma wyświetlić komunikat o błędzie
            if (!double.TryParse(inputWeight.Text, out double weight))
            {
                ErrorMessage.Visibility = Visibility.Visible;
                ErrorMessage.Text = "Type in number";
                inputWeight.Text = null;
            }

            else
            {
                // jeśli podane jest w lbs - ma przeliczyć na kg
                if (combobox.SelectedIndex == 1)
                {
                    weight = LbsToKg.ConvertToKg(weight);
                }

                // ma przeliczyć kg na zwierzęta i przekazac do nowego okna te listę

                ResultWindow resultWindow = new ResultWindow();
                resultWindow.Show();
            }
        }
    }
}
