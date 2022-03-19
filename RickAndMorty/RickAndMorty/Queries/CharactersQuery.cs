using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using RickAndMorty.Constants;
using RickAndMorty.Models;

namespace RickAndMorty.Queries
{
    public class CharactersQuery
    {
        private GraphQLHttpClient client;

        public async Task<List<Character>> GetAllCharacters(int pageNumber = 1)
        {
            client = new GraphQLHttpClient(APIEndpoints.RickAndMortyURI, new NewtonsoftJsonSerializer());

            GraphQLRequest query = new GraphQLRequest
            {
                Query = @"query {
                characters(page: 1) {
                    results{
                        id,
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
                }",

                /*
                OperationName = "characters",
                Variables = pageNumber
                */
            };

            GraphQLResponse<Query> graphQLResponse = await client.SendQueryAsync<Query>(query);

            return graphQLResponse.Data.Characters.Results;
        }
    }
}
