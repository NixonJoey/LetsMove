﻿using AppKit;
using Foundation;

namespace MoveTester
{
	[Register("AppDelegate")]
	public class AppDelegate : NSApplicationDelegate
	{
		public AppDelegate()
		{
			
		}

		public override void WillFinishLaunching(NSNotification notification)
		{
			//base.WillFinishLaunching(notification);
		}

		public override void DidFinishLaunching(NSNotification notification)
		{
			// Insert code here to initialize your application
		}

		public override void WillTerminate(NSNotification notification)
		{
			// Insert code here to tear down your application
		}
	}
}
