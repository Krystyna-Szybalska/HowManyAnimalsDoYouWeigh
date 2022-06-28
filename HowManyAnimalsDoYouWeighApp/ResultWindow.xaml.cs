using System.Windows;
using HowManyAnimalsDoYouWeighDomain;

namespace HowManyAnimalsDoYouWeighApp
{
    public partial class ResultWindow
    {
        public ResultWindow()
        {
            InitializeComponent();
        }


        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}