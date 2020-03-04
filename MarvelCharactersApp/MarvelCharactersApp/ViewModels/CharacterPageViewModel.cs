﻿using MarvelCharactersApp.Models;
using MarvelCharactersApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MarvelCharactersApp.ViewModels
{
   public  class CharacterPageViewModel:INotifyPropertyChanged
    {
        public Character Character { get; set; }
        public bool IsVisible { get; set; }
        readonly MarvelApi marvelApi = new MarvelApi();
        public ICommand ReadMoreCommand { get; set; }
        public ObservableCollection<Comic> Comics { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public CharacterPageViewModel(Character character)
        {
            Character = new Character();
           
            IsVisible = false;
            ReadMoreCommand = new Command(() => IsVisible = !IsVisible);
            Character = character;
            if (Character!=null)
            {
                LoadComics();
            }
           
        }
        async void LoadComics()
        {
            string id = Convert.ToString(Character.Id);
            var listComic = await marvelApi.GetComicCharacter(id);
            
            Comics = new ObservableCollection<Comic>(listComic.Data.Comics);
        }
    }
}
