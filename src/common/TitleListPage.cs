using System;

using Xamarin.Forms;

namespace XamarinHelloWorldApp
{
    public class TitleListPage : ContentPage
    {
        readonly ListView ItemList;

        public TitleListPage()
        {
            Title = "Titles";
            BindingContext = MainData.Instance;
            Content = (ItemList = new ListView
            {
                ItemTemplate = new DataTemplate(() =>
                {
                    Image thumb;
                    Label name;
                    var ret = new ViewCell()
                    {
                        View = new StackLayout()
                        {
                            HorizontalOptions = LayoutOptions.Fill,
                            VerticalOptions = LayoutOptions.CenterAndExpand,
                            Orientation = StackOrientation.Horizontal,
                            Padding = new Thickness(20, 0, 0, 0),
                            Children = {
                                (thumb = new Image()
                                {
                                    WidthRequest = 32,
                                    HeightRequest = 32,
                                    HorizontalOptions = LayoutOptions.Start,
                                    VerticalOptions = LayoutOptions.Center,
                                }),
                                (name = new Label()
                                {
                                    HorizontalOptions = LayoutOptions.Start,
                                    VerticalOptions = LayoutOptions.Center,
                                    HorizontalTextAlignment = TextAlignment.Start,
                                    VerticalTextAlignment = TextAlignment.Center,
                                    Margin = new Thickness(10, 0, 0, 0),
                                }),
                            }
                        }
                    };

                    name.SetBinding(Label.TextProperty, new Binding("Name"));
                    thumb.SetBinding(Image.SourceProperty, new Binding("Thumbnail"));

                    return ret;
                }),
            });

            ItemList.SetBinding(ListView.ItemsSourceProperty, new Binding("SelectedBookshelf.Titles", BindingMode.Default));
        }
    }
}

