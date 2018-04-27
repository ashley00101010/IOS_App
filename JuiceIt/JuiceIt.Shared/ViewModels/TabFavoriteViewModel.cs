﻿
using System;
using System.Collections.Generic;
using JuiceIt.Shared.Models;
using JuiceIt.Shared.Services;
using MvvmCross.Core.ViewModels;

namespace JuiceIt.Shared.ViewModels
{
    public class TabFavoriteViewModel : MvxViewModel
    {
        private ILocalDbService _localDbService;
        public TabFavoriteViewModel( ILocalDbService localDbService)
        {
            this._localDbService = localDbService;
        }
        private List<Favorites> _favorites;

        public List<Favorites> Favorites
        {
            get
            {
                return _favorites;
            }
            set
            {
                _favorites = value;
                RaisePropertyChanged(() => Favorites);
            }
        }

        public async void GetFavoriteData()
        {
            
            Favorites = await _localDbService.GetFavorite();
        }

        public IMvxCommand RemoveFavoriteCommand
        {
            get
            {
                return new MvxCommand<int>(RemoveFavorite);
            }
        }

        public void RemoveFavorite(int index)
        {
            Favorites f = Favorites[index];
            _localDbService.DeleteFavorite(f.Id);
            GetFavoriteData();

        }

		public override void ViewAppearing()
		{
            base.ViewAppearing();
            GetFavoriteData();
		}


	}
}