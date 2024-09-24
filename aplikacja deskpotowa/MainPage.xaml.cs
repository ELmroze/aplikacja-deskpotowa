using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace aplikacja_deskpotowa
{
    public partial class MainPage : ContentPage
    {
        string haslo;
        //ten string liczby od 0-9 ma duże i małe litery od 10-61 znaki specjalne od 62-89
        string znaki_do_hasla = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM!@#$%^&*()-=_+][}{\'\"\\<>,./?|";
        void randomizacja(int znaki, int wybur)
        {
            var rand =new Random();
            haslo = "";
            char znak;
            for (int i = 0; i < znaki; i++)
            {
                haslo += znaki_do_hasla[rand.Next(znaki_do_hasla.Length)];
            }
        }
        
        public MainPage()
        {
            InitializeComponent();
        }
        
        private async void zatwierdz(object sender, EventArgs e)
        {
            await DisplayAlert("", "Dane pracownika: "+imie.Text+" "+nazwisko.Text+" "+picker.SelectedItem +" hasło: "+haslo, "OK");
        }

        private async void generuj(object sender, EventArgs e)
        {
            if (check1.IsChecked && check2.IsChecked && check3.IsChecked)
            {
                randomizacja(5, 1);
                await DisplayAlert("", haslo, "OK");
            }
        }
    }

}
