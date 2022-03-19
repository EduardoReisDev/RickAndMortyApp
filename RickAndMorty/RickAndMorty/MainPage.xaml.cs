using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using RickAndMorty.Constants;
using RickAndMorty.Models;
using RickAndMorty.Queries;
using Xamarin.Forms;

namespace RickAndMorty
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Teste();
        }

        public void Teste()
        {
            CharactersQuery query = new CharactersQuery();
            query.GetAllCharactersAsync();
        }
    }
}
