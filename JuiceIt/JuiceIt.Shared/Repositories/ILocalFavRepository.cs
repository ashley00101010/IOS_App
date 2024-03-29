﻿using System.Collections.Generic;
using System.Threading.Tasks;
using JuiceIt.Shared.Models;
using SQLite;

namespace JuiceIt.Shared.Repositories
{
    public interface ILocalFavRepository
    {
        void SetupDatabase();
        Favorites AddFavorites(Recipe recipe);
        Task<List<Favorites>> GetFavorites();
        Task<Favorites> GetFavoritesById(int FavoriteId);
        Task DeleteFavorite(int id);
    }
}