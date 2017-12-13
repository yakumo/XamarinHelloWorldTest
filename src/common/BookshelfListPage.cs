using System;

using Xamarin.Forms;

namespace XamarinHelloWorldApp
{
    public class BookshelfListPage : ContentPage
    {
        readonly ListView ItemList;

        public BookshelfListPage()
        {
            Title = "Bookshelves";
            BindingContext = MainData.Instance;
            Content = (ItemList = new ListView()
            {
                ItemTemplate = new DataTemplate(() =>
                {
                    Label NameLabel;
                    var ret = new ViewCell()
                    {
                        View = (NameLabel = new Label()
                        {
                            HorizontalOptions = LayoutOptions.Start,
                            VerticalOptions = LayoutOptions.Center,
                            HorizontalTextAlignment = TextAlignment.Start,
                            VerticalTextAlignment = TextAlignment.Center,
                            Margin = new Thickness(20, 0, 0, 0),
                        }),
                    };

                    NameLabel.SetBinding(Label.TextProperty, new Binding("Name"));

                    return ret;
                }),
            });

            ItemList.SetBinding(ListView.ItemsSourceProperty, new Binding("Bookshelves", BindingMode.Default));
            ItemList.SetBinding(ListView.SelectedItemProperty, new Binding("SelectedBookshelf", BindingMode.TwoWay));
        }
    }
}

