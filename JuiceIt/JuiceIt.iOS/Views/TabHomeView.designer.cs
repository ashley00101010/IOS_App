// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace JuiceIt.iOS.Views
{
    [Register ("TabHomeView")]
    partial class TabHomeView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView image { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel JuiceName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView Name { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton RandomJuiceBtn { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (image != null) {
                image.Dispose ();
                image = null;
            }

            if (JuiceName != null) {
                JuiceName.Dispose ();
                JuiceName = null;
            }

            if (Name != null) {
                Name.Dispose ();
                Name = null;
            }

            if (RandomJuiceBtn != null) {
                RandomJuiceBtn.Dispose ();
                RandomJuiceBtn = null;
            }
        }
    }
}