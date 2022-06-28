using System.Windows;
using System.Windows.Controls;
using HowManyAnimalsDoYouWeighDomain;

namespace HowManyAnimalsDoYouWeighApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_OnClick(object sender, RoutedEventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void ClearButton_OnClick(object sender, RoutedEventArgs e)
        {
          //  throw new NotImplementedException();
        }

        private void CurrentSection_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void SearchTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void FiltersCheckbox_OnClick(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            // jeśli wpisana wartość jest niepoprawna - ma wyświetlić komunikat o błędzie
            if (!double.TryParse(input.Text, out double weight))
            {
                ErrorMessage.Visibility = Visibility.Visible;
                ErrorMessage.Text = "Type in number";
                input.Text = null;
            }

            else
            {
                // jeśli podane jest w lbs - ma przeliczyć na kg
                if (combobox.SelectedIndex == 1)
                {
                    weight = LbsToKg.ConvertToKg(weight);
                }

                // ma przeliczyć kg na zwierzęta

                ResultWindow resultWindow = new ResultWindow();
                resultWindow.Show();
            }
        }
    }
}
