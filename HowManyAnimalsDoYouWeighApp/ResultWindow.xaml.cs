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

        private void OKButton_Click(object sender, RoutedEventArgs e)
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

                double ants = Animals.ToAnts(weight);
                double chihuahuas = Animals.ToChihuahuas(weight);
                double elephants = Animals.ToElephants(weight);
                ErrorMessage.Visibility = Visibility.Visible;
                ErrorMessage.Text = $"You weigh approximately:\n {ants} ants\n {chihuahuas} chihuahuas\n {elephants} elephants";
            }


            // ma otworzyć ResultWindow i wypisać w nim wyniki (jeśli da się zrobić coś takiego)
        }
    }
}