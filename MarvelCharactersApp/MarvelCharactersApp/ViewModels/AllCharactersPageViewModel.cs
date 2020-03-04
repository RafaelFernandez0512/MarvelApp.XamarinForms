using MarvelCharactersApp.Models;
using MarvelCharactersApp.Services;
using MarvelCharactersApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace MarvelCharactersApp.ViewModels
{
    public class AllCharactersPageViewModel:INotifyPropertyChanged
    {
        public ObservableCollection<Character> Characters { get; set; }
        readonly IMarvelApiHttps marvelApiRefit = new MarvelApi();
        private Character selectCharacter;

        public event PropertyChangedEventHandler PropertyChanged;

        public Character SelectCharacter
        {
            get { return selectCharacter; }
            set
            {
                selectCharacter = value;
                if (selectCharacter != null)
                {
                    InfoCharacter(SelectCharacter);
                }

            }
        }
        public AllCharactersPageViewModel()
        {
            LoadCharacters();
        }
        async void InfoCharacter(Character character)
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new CharacterPage(character));
        }
        async void LoadCharacters()
        {
            var list = await marvelApiRefit.GetAllCharacter();
            Characters = new ObservableCollection<Character>(list.Data.Characters);
        }
    }
}
