using AppKit;
using Foundation;

namespace HelloWorldTest
{
    [Register("AppDelegate")]
    public class AppDelegate : Xamarin.Forms.Platform.MacOS.FormsApplicationDelegate // NSApplicationDelegate
    {
        public AppDelegate()
        {
            Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
        }

        public override NSWindow MainWindow => MainViewController?.View.Window;
        public ViewController MainViewController { get; set; }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }

        public override bool ApplicationShouldTerminateAfterLastWindowClosed(NSApplication sender)
        {
            return true;
        }
    }

    public class App : Xamarin.Forms.Application
    {
        public App()
        {
        }
    }
}
