using System;
using System.Collections.ObjectModel;
using RickAndMorty.Models;
using RickAndMorty.Queries;

namespace RickAndMorty.ViewModels
{
    public class DashboardPageViewModel : BaseViewModel
    {
        public ObservableCollection<Character> CharactersList { get; set; }

        public DashboardPageViewModel()
        {
            
        }

        public async void FillCharactersList()
        {
            CharactersQuery query = new CharactersQuery();
            CharactersList = new ObservableCollection<Character>();

            foreach (Character character in await query.GetAllCharacters())
            {
                CharactersList.Add(character);
            }
        }
    }
}
