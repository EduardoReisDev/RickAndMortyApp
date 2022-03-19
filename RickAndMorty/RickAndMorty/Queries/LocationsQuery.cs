using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using RickAndMorty.Constants;
using RickAndMorty.Models;

namespace RickAndMorty.Queries
{
    public class LocationsQuery
    {
        private GraphQLHttpClient client;

        public async Task<List<Location>> GetAllLocations(int pageNumber)
        {
            client = new GraphQLHttpClient(APIEndpoints.RickAndMortyURI, new NewtonsoftJsonSerializer());

            GraphQLRequest query = new GraphQLRequest
            {
                Query = @"query {
                locations(page: $pageNumber) {
                    results{
                        id,
                        name,
                        type,
      	                dimension,
      	                residents{
                            id,
                            name,
                            status,
                            species,
                            type,
                            gender,
                            image,
                      }
                    }
                  }
                }",
                Variables = pageNumber
            };

            GraphQLResponse<Query> graphQLResponse = await client.SendQueryAsync<Query>(query);

            return graphQLResponse.Data.Locations.Results;
        }
    }
}
