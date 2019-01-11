using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Next_moov.Models;
using Next_moov.DAL;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace Next_moov.ViewModels
{
	public class ListFilmPageViewModel : BaseViewModel
	{
        public ListFilmPageViewModel()
        {
            Titre = "Next Moov";
            RefreshFilmsCommand = new Command(
                async () => await ExecuteRefreshFilmsCommand());
            RefreshFilmsCommand.Execute(null);
        }

        #region Bindable Properties

        private List<Result> listfilms;
        public List<Result> ListFilms
        {
            get
            {
                return listfilms;
            }
            set
            {
                listfilms = value;
                OnPropertyChanged("listfilms");
            }
        }



        private Result selectedfilm;
        public Result SelectedFilm
        {
            get
            {
                return selectedfilm;
            }
            set
            {
                selectedfilm = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Bindable Commands

        public Command RefreshFilmsCommand { get; set; }

        private async Task ExecuteRefreshFilmsCommand()
        {
            IsBusy = true;
            //si on est en ligne

            IsBusy = false;
        }

        #endregion
    }
}