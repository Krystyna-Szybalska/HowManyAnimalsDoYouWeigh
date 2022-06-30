using System.Windows;
using HowManyAnimalsDoYouWeighApp.ViewModels;
using HowManyAnimalsDoYouWeighDomain;

namespace HowManyAnimalsDoYouWeighApp
{
    public partial class ResultWindow
    {        
        public MainViewModel MainViewModel { get; set; } = new();

        public ResultWindow()
        {
            InitializeComponent();
            this.DataContext = MainViewModel; //is this even correct?
        }

        private void ShowCorrectListView()
        {
            switch (MainViewModel.ActiveListView)
            {
                case ListViewName.Animals:
                    break;
            }
        }
            
        private void OkButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}