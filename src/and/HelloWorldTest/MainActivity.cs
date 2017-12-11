using Android.App;
using Android.Widget;
using Android.OS;
using XamarinHelloWorldApp;

namespace HelloWorldTest
{
    [Activity(Label = "HelloWorldTest", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsApplicationActivity // Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new HelloWorldApp());
        }
    }
}

