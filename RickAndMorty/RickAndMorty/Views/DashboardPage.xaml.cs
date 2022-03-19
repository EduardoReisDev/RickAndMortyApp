using System;
using System.Collections.Generic;
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

            viewModel.FillCharactersList();
        }
    }
}
