using Next_moov.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Next_moov.ViewModels
{
    public class DetailFilmPageViewModel : BaseViewModel
    {
        public DetailFilmPageViewModel(Result film)
        {
            CurrentFilm = film;
            Titre = "Film Detail";
        }

        #region BindableProperties

        private Result currentfilm;
        public Result CurrentFilm
        {
            get { return currentfilm; }
            set
            {
                currentfilm = value;
                OnPropertyChanged();
            }
        }

        #endregion

    }
}