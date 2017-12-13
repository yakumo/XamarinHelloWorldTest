using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;
using XamarinHelloWorldApp;
using Xamarin.Forms.Platform.MacOS;

namespace HelloWorldTest
{
    public partial class TitlesViewController : AppKit.NSViewController
    {
        #region Constructors

        // Called when created from unmanaged code
        public TitlesViewController(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public TitlesViewController(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        // Call to load from the XIB/NIB file
        public TitlesViewController() : base("TitlesView", NSBundle.MainBundle)
        {
            Initialize();
        }

        // Shared initialization code
        void Initialize()
        {
        }

        #endregion

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var p = new TitleListPage();
            var c = p.CreateViewController();
            c.View.AutoresizingMask = NSViewResizingMask.HeightSizable | NSViewResizingMask.WidthSizable;
            c.View.Frame = new CoreGraphics.CGRect(0, 0, View.Frame.Width, View.Frame.Height);
            this.AddChildViewController(c);
            View.AddSubview(c.View);
        }
    }
}
