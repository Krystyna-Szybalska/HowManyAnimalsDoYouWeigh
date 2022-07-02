using System.Windows;
using HowManyAnimalsDoYouWeighApp.ViewModels;

namespace HowManyAnimalsDoYouWeighApp
{
    public partial class ResultWindow
    {
        public ResultWindow(MainResultViewModel mainResultViewModel)
        {
            InitializeComponent();
            this.DataContext = mainResultViewModel;
            SetListViewVisibility(mainResultViewModel);
        }

        private void SetListViewVisibility(MainResultViewModel mainResultViewModel)
        {
            if (AnimalsResultsListView is not null) {
                AnimalsResultsListView.Visibility = mainResultViewModel.ActiveListView == ListViewName.Animals
                    ? Visibility.Visible
                    : Visibility.Collapsed;
            }

            if (SubstancesResultsListView is not null) {
                SubstancesResultsListView.Visibility = mainResultViewModel.ActiveListView == ListViewName.Substances
                    ? Visibility.Visible
                    : Visibility.Collapsed;
            }

            if (ItemsResultsListView is not null) {
                ItemsResultsListView.Visibility = mainResultViewModel.ActiveListView == ListViewName.Items
                    ? Visibility.Visible
                    : Visibility.Collapsed;
            }
        }
        private void OkButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}