using MarvelCharactersApp.Models;
using MarvelCharactersApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MarvelCharactersApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterPage : ContentPage
    {
        public CharacterPage(Character character)
        {
            InitializeComponent();
            BindingContext = new CharacterPageViewModel(character);
        }
    }
}