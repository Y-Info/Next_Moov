using Next_moov.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Next_moov
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void BtnJson_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListFilmPage());
        }
    }
}
