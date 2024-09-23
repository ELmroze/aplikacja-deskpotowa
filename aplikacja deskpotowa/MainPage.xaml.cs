using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace aplikacja_deskpotowa
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        
        private async void zatwierdz(object sender, EventArgs e)
        {
            await DisplayAlert("", "Dane pracownika: "+imie.Text+" "+nazwisko.Text+" "+picker.SelectedItem, "OK");
        }

        private void generuj(object sender, EventArgs e)
        {
            if (check1.IsChecked)
            {
            }
        }
    }

}
