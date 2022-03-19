using RickAndMorty.ViewModels;
using Xamarin.Forms;

namespace RickAndMorty.Views
{
    public partial class LocationPage : ContentPage
    {
        private readonly LocationPageViewModel viewModel;

        public LocationPage()
        {
            InitializeComponent();

            viewModel = new LocationPageViewModel();
            BindingContext = viewModel;

            viewModel.FillLocationList();
        }
    }
}
