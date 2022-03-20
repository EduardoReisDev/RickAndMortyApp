using System.Collections.ObjectModel;
using System.Threading.Tasks;
using RickAndMorty.Models;
using RickAndMorty.Queries;
using Xamarin.Forms.Extended;

namespace RickAndMorty.ViewModels
{
    public class DashboardPageViewModel : BaseViewModel
    {
        public InfiniteScrollCollection<Character> CharactersList { get; set; }

        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }

        private bool isBusy;
        private int pageNumber = 1;

        public DashboardPageViewModel()
        {
            CharactersQuery query = new();

            CharactersList = new InfiniteScrollCollection<Character>
            {
                OnLoadMore = async () =>
                {
                    IsBusy = true;

                    pageNumber++;

                    var characters = await query.GetAllCharacters(pageNumber);

                    IsBusy = false;

                    return characters;
                }
            };

            FillCharactersList();
        }


        public async void FillCharactersList()
        {
            CharactersQuery query = new CharactersQuery();
            
            foreach (Character character in await query.GetAllCharacters(pageNumber))
            {
                CharactersList.Add(character);
            }
        }

    }
}
