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
using Xamarin.Forms;

namespace RickAndMorty
{
    public partial class MainPage : ContentPage
    {
        private GraphQLHttpClient client;

        public MainPage()
        {
            InitializeComponent();

            Teste();
        }

        public async void Teste()
        {
            client = new GraphQLHttpClient(APIEndpoints.RickAndMortyURI, new NewtonsoftJsonSerializer());

            var query = new GraphQLRequest
            {
                Query = @"query {
                  characters(page: 1) {
                    results {
                      name,
                      status,
  		                species,
  		                type,
  		                gender,
                      image,
  		                origin{
                        id,
  			                name,
  		                  type,
                      }
  		                location{
                        id,
  			                name,
  		                  type,
                      }
                    }
                  }
                }"
            };

            var response = await client.SendQueryAsync<Types.Query>(query);
            Console.WriteLine(response.Data);
        }
    }
}
