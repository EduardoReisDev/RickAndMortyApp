using RickAndMorty.Models;
using Xamarin.Forms;

namespace RickAndMorty.Views
{
    public partial class CharacterPage : ContentPage
    {
        private readonly Character character;

        public CharacterPage(Character character)
        {
            InitializeComponent();

            this.character = character;

            SetCharacterInformation();
        }

        private void SetCharacterInformation()
        {
            CharacterImage.Source = character.Image;
            CharacterName.Text = character.Name;
            CharacterStatusImage.Source = character.StatusImage;
            CharacterStatus.Text = character.Status;
            CharacterSpecie.Text = character.Species;
            CharacterGender.Text = character.Gender;
            CharacterLocation.Text = character.Location.Name;
            CharacterOrigin.Text = character.Origin.Name;
        }
    }
}
