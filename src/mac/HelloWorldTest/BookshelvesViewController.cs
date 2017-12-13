using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using AppKit;
using XamarinHelloWorldApp;
using Xamarin.Forms.Platform.MacOS;

namespace HelloWorldTest
{
    public partial class BookshelvesViewController : AppKit.NSViewController
    {
        #region Constructors

        // Called when created from unmanaged code
        public BookshelvesViewController(IntPtr handle) : base(handle)
        {
            Initialize();
        }

        // Called when created directly from a XIB file
        [Export("initWithCoder:")]
        public BookshelvesViewController(NSCoder coder) : base(coder)
        {
            Initialize();
        }

        // Call to load from the XIB/NIB file
        public BookshelvesViewController() : base("BookshelvesView", NSBundle.MainBundle)
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

            var p = new BookshelfListPage();
            var c = p.CreateViewController();
            c.View.AutoresizingMask = NSViewResizingMask.HeightSizable | NSViewResizingMask.WidthSizable;
            c.View.Frame = new CoreGraphics.CGRect(0, 0, View.Frame.Width, View.Frame.Height);
            this.AddChildViewController(c);
            View.AddSubview(c.View);
        }
    }
}
