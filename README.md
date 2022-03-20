# RickAndMortyApp :ringed_planet:
Aplicativo desenvolvido em Xamarin.Forms (iOS e Android) consumindo API GraphQL.

![rick-and-morty-glootie-do-not-develop-my-app-512x512](https://user-images.githubusercontent.com/52722526/159149086-2056829d-dd14-4f32-8134-814016142fe2.png)

## Plugins e Framework
#### Plugins

- GraphQL.Client
- GraphQL.Client.Serializer.Newtonsoft
- Xamarin.Forms.Extended.InfiniteScrolling (pre-release)

#### Framework
- Xamarin.Forms
- Xamarin.Essentials

## API
#### Endpoint
- https://rickandmortyapi.com/graphql

#### Queries
```
@"query GetAllLocations($number: Int)
{
    locations(page: $number)
    {
        results
        {
            id,
            name,
            type,
            dimension,
            residents
            {
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
}"
```

```
@"query
  GetAllCharacters($number: Int)
  {
    characters(page: $number)
      {
          results
          {
            id,
              name,
              status,
              species,
              type,
              gender,
              image,
              origin
              {  
                  id,
                  name,
                  type
              }
              location
              {
                  id,
                  name,
                  type,
              }
          }
    }
  }"
```

## Medium
Leia mais sobre a aplicação.
- ...

## Resultado
https://user-images.githubusercontent.com/52722526/159149017-58b18674-7ade-41ec-84c8-47e07072ee47.mp4

###### Obrigado!
