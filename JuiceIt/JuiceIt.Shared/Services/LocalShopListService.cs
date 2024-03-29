﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JuiceIt.Shared.Models;
using JuiceIt.Shared.Repositories;

namespace JuiceIt.Shared.Services
{
    public class LocalShopListService : ILocalShopListService
    {
        private ILocalShopListRepository _localShopListRepository;
        public LocalShopListService(ILocalShopListRepository localShopListRepository)
        {
            this._localShopListRepository = localShopListRepository;
        }

        public async Task<List<ShopList>> GetShopList()
        {
            _localShopListRepository.SetupDatabase();
            return await _localShopListRepository.GetShopList();
        }
        public async Task<List<ShopList>> GetShopListAgain()
        {
            return await _localShopListRepository.GetShopList();
        }
        public Recipe AddShopList(Recipe recipe)
        {

            _localShopListRepository.AddShopList(recipe);
            return recipe;
        }

        public Favorites AddShopListFromLocal(Favorites favorite)
        {

            _localShopListRepository.AddShopListFromLocal(favorite);
            return favorite;
        }

        public async Task DeleteShopListItem(int id)
        {
            await _localShopListRepository.DeleteShopListItem(id);
        }

        public ShopList AddShopListChecker()
        {
            return _localShopListRepository.AddShopListChecker();
        }
    }
}
