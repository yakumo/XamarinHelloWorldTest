using System;

using Xamarin.Forms;

namespace XamarinHelloWorldApp
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Content = new StackLayout
            {
                BackgroundColor = Color.FromRgb(240, 255, 240),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    new Label
                    {
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center,
                        Text = "Hello World",
                        TextColor = Color.FromRgb(128, 175, 128),
                    }
                }
            };
        }
    }
}

