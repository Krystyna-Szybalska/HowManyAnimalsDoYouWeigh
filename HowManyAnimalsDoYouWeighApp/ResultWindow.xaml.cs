using System.Windows;
using System.Windows.Controls;
using HowManyAnimalsDoYouWeighApp.ViewModels;
using HowManyAnimalsDoYouWeighDomain;

namespace HowManyAnimalsDoYouWeighApp
{
    public partial class ResultWindow
    {
        public MainResultViewModel MainResultViewModel = new MainResultViewModel();
        public ResultWindow(MainResultViewModel mainResultViewModel)
        {
            InitializeComponent();
            this.DataContext = mainResultViewModel; //is this even correct?
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