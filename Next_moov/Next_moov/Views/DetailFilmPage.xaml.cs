using Next_moov.Models;
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
        public DetailFilmPage(results SelectedContact)
        {
            InitializeComponent();

            GridDetails.BindingContext = SelectedContact;
        }
    }
}