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
        private CharactersQuery query;

        public DashboardPageViewModel()
        {
            query = new CharactersQuery();

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
        }

        public async void FillCharactersList()
        {
            IsBusy = true;

            foreach (Character character in await query.GetAllCharacters(pageNumber))
            {
                CharactersList.Add(character);
            }

            IsBusy = false;
        }
    }
}
