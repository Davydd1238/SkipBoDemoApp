using SkipBoDemoLibrary;

namespace SkipBoDemoUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnNewGameClicked(object? sender, EventArgs e)
        {            
            ChooseHowManyPlayersPage chooseHowManyPlayersPage = new ChooseHowManyPlayersPage();
            Navigation.PushAsync(chooseHowManyPlayersPage);
        }
    }
}
