using Blazored.LocalStorage;

namespace DailyLift.Services
{
    public class FavoritesService
    {
        private readonly ILocalStorageService _storage;

        private const string KEY = "favoriteLiftIds";

        public FavoritesService(
            ILocalStorageService storage)
        {
            _storage = storage;
        }

        public async Task<List<int>> GetFavoritesAsync()
        {
            return await _storage
                .GetItemAsync<List<int>>(KEY)
                ?? new List<int>();
        }

        public async Task AddFavoriteAsync(int id)
        {
            var favorites = await GetFavoritesAsync();

            if (!favorites.Contains(id))
            {
                favorites.Add(id);

                await _storage.SetItemAsync(KEY, favorites);
            }
        }

        public async Task RemoveFavoriteAsync(int id)
        {
            var favorites = await GetFavoritesAsync();

            if (favorites.Contains(id))
            {
                favorites.Remove(id);

                await _storage.SetItemAsync(KEY, favorites);
            }
        }

        public async Task<bool> IsFavoriteAsync(int id)
        {
            var favorites = await GetFavoritesAsync();

            return favorites.Contains(id);
        }
    }
}