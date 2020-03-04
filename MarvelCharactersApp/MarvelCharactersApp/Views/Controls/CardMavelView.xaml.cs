using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MarvelCharactersApp.Views.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardMavelView : ContentView
    {
        public static readonly BindableProperty ItemsSourceProperty = BindableProperty.Create(
            nameof(ItemsSource),
            typeof(IList),
            typeof(CardMavelView),
            propertyChanged: ColletionViewChanged);
        public IList ItemsSource
        {
            get => (IList)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }
        private static void ColletionViewChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(bindable is CardMavelView control)) return;
            var items = (IList)newValue;
            control.xItemsLists.ItemsSource = items;
        }
        public CardMavelView()
        {
            InitializeComponent();
        }
    }
}