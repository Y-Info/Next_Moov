using Microsoft.AppCenter.Analytics;
using Next_moov.Models;
using Next_moov.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Next_moov.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailFilmPage : ContentPage
    {
        public DetailFilmPage(Result SelectedFilm)
        {
            InitializeComponent();
            BindingContext = new DetailFilmPageViewModel(SelectedFilm);
            Analytics.TrackEvent("Views_on_details");
            GridDetails.BindingContext = SelectedFilm;
        }
    }
}