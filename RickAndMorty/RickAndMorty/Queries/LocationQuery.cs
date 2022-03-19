using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using RickAndMorty.Constants;
using RickAndMorty.Models;

namespace RickAndMorty.Queries
{
    public class LocationQuery
    {
        private GraphQLHttpClient client;

        public async Task<Location> GetLocation(int locationId)
        {
            client = new GraphQLHttpClient(APIEndpoints.RickAndMortyURI, new NewtonsoftJsonSerializer());

            GraphQLRequest query = new GraphQLRequest
            {
                Query = @"query {
                location(id: $locationId){
                    id,
                    name,
                    type,
  		            dimension,
  		            residents{
                        id,
                        name,
                        status,
                        gender,
                        species,
                        type,
                        image,
                    }
                  }
                }",
                Variables = locationId
            };

            GraphQLResponse<Query> graphQLResponse = await client.SendQueryAsync<Query>(query);

            return graphQLResponse.Data.Location;
        }
    }
}
