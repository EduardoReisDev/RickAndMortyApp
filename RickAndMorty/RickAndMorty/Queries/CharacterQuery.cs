using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using RickAndMorty.Constants;
using RickAndMorty.Models;

namespace RickAndMorty.Queries
{
    public class CharacterQuery
    {
        private GraphQLHttpClient client;

        public async Task<Character> GetCharacter(int characterId)
        {
            client = new GraphQLHttpClient(APIEndpoints.RickAndMortyURI, new NewtonsoftJsonSerializer());

            GraphQLRequest query = new GraphQLRequest
            {
                Query = @"query {
                character(id: $characterId){
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
                }",
                Variables = characterId
            };

            GraphQLResponse<Query> graphQLResponse = await client.SendQueryAsync<Query>(query);

            return graphQLResponse.Data.Character;
        }
    }
}
