// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace JuiceIt.iOS.JuicIt.WatchExtension
{
    [Register ("InterfaceController")]
    partial class InterfaceController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceTable MyTable { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (MyTable != null) {
                MyTable.Dispose ();
                MyTable = null;
            }
        }
    }
}