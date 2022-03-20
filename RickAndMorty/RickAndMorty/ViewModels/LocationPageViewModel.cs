using RickAndMorty.Models;
using RickAndMorty.Queries;
using Xamarin.Forms.Extended;

namespace RickAndMorty.ViewModels
{
    public class LocationPageViewModel : BaseViewModel
    {
        public InfiniteScrollCollection<Location> LocationsList { get; set; }

        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }

        private bool isBusy = false;
        private int pageNumber = 1;
        private LocationsQuery query;

        public LocationPageViewModel()
        {
            query = new LocationsQuery();
            LocationsList = new InfiniteScrollCollection<Location>
            {
                OnLoadMore = async () =>
                {
                    IsBusy = true;

                    pageNumber++;

                    var locations = await query.GetAllLocations(pageNumber);

                    IsBusy = false;

                    return locations;
                }
            };
        }

        public async void FillLocationList()
        {
            IsBusy = true;

            foreach (Location location in await query.GetAllLocations(pageNumber))
            {
                LocationsList.Add(location);
            }

            IsBusy = false;
        }
    }
}
