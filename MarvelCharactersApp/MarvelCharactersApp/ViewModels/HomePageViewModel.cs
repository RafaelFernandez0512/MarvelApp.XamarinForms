using MarvelCharactersApp.Models;
using MarvelCharactersApp.Services;
using MarvelCharactersApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MarvelCharactersApp.ViewModels
{
    public class HomePageViewModel:INotifyPropertyChanged
    {
       public ObservableCollection<Character> Characters { get; set; }
        readonly MarvelApi marvelApiRefit = new MarvelApi();

        private Character selectCharacter;

        public Character SelectCharacter
        {
            get { return selectCharacter; }
            set {
                selectCharacter = value;
                if (selectCharacter!=null)
                {
                    InfoCharacter(SelectCharacter);
                }
               
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public HomePageViewModel()
        {
            LoadList();

        }
        async void LoadList()
        {
            if (Connectivity.NetworkAccess==NetworkAccess.Internet)
            {
                try
                {
                    var loadcharacters = await marvelApiRefit.GetModifiedCharacter();
                    Characters = new ObservableCollection<Character>(loadcharacters.Data.Characters);
                }
                catch (Exception err)
                {

                    await App.Current.MainPage.DisplayAlert("Connection error ", err.Message, "Ok");
                }

            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Connection error ", Connectivity.NetworkAccess.ToString(),"Ok");
            }

        }
        async void InfoCharacter(Character character)   
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new CharacterPage(character)) ;
        }

    }
}
