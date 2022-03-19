using System.Collections.ObjectModel;
using RickAndMorty.Models;
using RickAndMorty.Queries;

namespace RickAndMorty.ViewModels
{
    public class LocationPageViewModel : BaseViewModel
    {
        public ObservableCollection<Location> LocationsList { get; set; }

        public LocationPageViewModel()
        {
            LocationsList = new ObservableCollection<Location>();
        }

        public async void FillLocationList()
        {
            LocationsQuery query = new LocationsQuery();

            foreach(Location location in await query.GetAllLocations())
            {
                LocationsList.Add(location);
            }
        }
    }
}
