﻿using System;

using Foundation;
using JuiceIt.iOS.JuicIt.WatchExtension.SessionManager;
using WatchKit;

namespace JuiceIt.iOS.JuicIt.WatchExtension
{
    [Register("ExtensionDelegate")]
    public class ExtensionDelegate : WKExtensionDelegate
    {
        
        public override void ApplicationDidFinishLaunching()
        {
            WCSessionManager.SharedManager.StartSession();
        }

        public override void ApplicationDidBecomeActive()
        {
            // Restart any tasks that were paused (or not yet started) while the application was inactive.
            // If the application was previously in the background, optionally refresh the user interface.
        }

        public override void ApplicationWillResignActive()
        {
            // Sent when the application is about to move from active to inactive state.
            // This can occur for certain types of temporary interruptions
            // (such as an incoming phone call or SMS message) or when the user quits the application
            // and it begins the transition to the background state.
            // Use this method to pause ongoing tasks, disable timers, etc.
        }
    }
}

