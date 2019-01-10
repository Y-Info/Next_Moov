using Newtonsoft.Json;
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
	public partial class ListFilmPage : ContentPage
	{
		public ListFilmPage()
		{
            InitializeComponent();
            GetJSON();
        }
        public async void GetJSON()
        {
            //Check network status 
            if (NetworkCheck.IsInternet())
            {

                var client = new System.Net.Http.HttpClient();
                var response = await client.GetAsync("https://api.themoviedb.org/3/movie/upcoming?api_key=440d3555391bf8ebbceae19005baea22&language=fr-FR&page=1");
                string contactsJson = response.Content.ReadAsStringAsync().Result;
                ContactList ObjContactList = new ContactList();
                if (contactsJson != "")
                {
                    //Converting JSON Array Objects into generic list
                    ObjContactList = JsonConvert.DeserializeObject<ContactList>(contactsJson);
                }
                //Binding listview with server response  
                listviewConacts.ItemsSource = ObjContactList.Results;
            }
            else
            {
                await DisplayAlert("JSONParsing", "No network is available.", "Ok");
            }
            //Hide loader after server response  
            ProgressLoader.IsVisible = false;
        }

        private void listviewContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var itemSelectedData = e.SelectedItem as results;
            Navigation.PushAsync(new DetailFilmPage(itemSelectedData));
        }
    }
}