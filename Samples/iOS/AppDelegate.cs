﻿using UIKit;
using Foundation;

using EntryCustomReturn.Forms.Plugin.iOS;

namespace EntryCustomReturnSampleApp.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App());

			CustomReturnEntryRenderer.Init();

#if DEBUG
			Xamarin.Calabash.Start();
#endif

			return base.FinishedLaunching(app, options);
		}
	}
}
