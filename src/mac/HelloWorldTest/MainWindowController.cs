using System;

using Foundation;
using AppKit;

namespace HelloWorldTest
{
    public partial class MainWindowController : NSWindowController
    {
        public MainWindowController(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public MainWindowController(NSCoder coder) : base(coder)
        {
        }

        public MainWindowController() : base("MainWindow")
        {
        }

        public override void WindowDidLoad()
        {
            base.WindowDidLoad();

            Window.TitleVisibility = NSWindowTitleVisibility.Hidden;
        }
    }
}
