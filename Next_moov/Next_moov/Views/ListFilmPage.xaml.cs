﻿using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Newtonsoft.Json;
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
	public partial class ListFilmPage : ContentPage
	{
		public ListFilmPage()
		{
            InitializeComponent();
            Analytics.TrackEvent("Views_on_details");
            BindingContext = new ListFilmPageViewModel();

            GetJSON();
        }

        public async void GetJSON()
        {



            if (NetworkCheck.IsInternet())
            {

                var client = new System.Net.Http.HttpClient();
                var response = await client.GetAsync("https://api.themoviedb.org/3/movie/upcoming?api_key=440d3555391bf8ebbceae19005baea22&language=fr-FR&page=1");
                string contactsJson = response.Content.ReadAsStringAsync().Result;
                FilmList ObjContactList = new FilmList();

                // Test crash
                //contactsJson = "";
                    try
                    {
                        
                        //Converting JSON Array Objects into generic list
                        ObjContactList = JsonConvert.DeserializeObject<FilmList>(contactsJson);

                    }
                    catch (Exception exception)
                    {
                        Crashes.TrackError(exception);
                    }
                //Binding listview with server response  
                listviewFilms.ItemsSource = ObjContactList.Results;
            }
            else
            {
                await DisplayAlert("JSONParsing", "No network is available.", "Ok");
                Analytics.TrackEvent("No_Internet");
            }
            //Hide loader after server response  
            ProgressLoader.IsVisible = false;
        }

        private void listviewFilms_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var itemSelectedData = e.SelectedItem as Result;
            Navigation.PushAsync(new DetailFilmPage(itemSelectedData));
        }
    }
}