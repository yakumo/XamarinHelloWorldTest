using System;
using Xamarin.Forms;

namespace XamarinHelloWorldApp
{
    public class HelloWorldApp : Xamarin.Forms.Application
    {
        public HelloWorldApp()
        {
            MainPage = new NavigationPage(
                new MasterDetailPage()
                {
                    Master = new BookshelfListPage(),
                    Detail = new TitleListPage()
                }
            );
        }
    }
}
