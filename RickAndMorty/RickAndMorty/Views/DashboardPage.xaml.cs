using System;
using RickAndMorty.Models;
using RickAndMorty.ViewModels;
using Xamarin.Forms;

namespace RickAndMorty.Views
{
    public partial class DashboardPage : ContentPage
    {
        private readonly DashboardPageViewModel viewModel;

        public DashboardPage()
        {
            InitializeComponent();

            viewModel = new DashboardPageViewModel();
            BindingContext = viewModel;
        }

        private async void GoToLocationPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LocationPage());
        }

        private async void CharacterItemTapped(object sender, ItemTappedEventArgs e)
        {
            Character selectedCharacter = e.Item as Character;

            await Navigation.PushAsync(new CharacterPage(selectedCharacter));
        }
    }
}
