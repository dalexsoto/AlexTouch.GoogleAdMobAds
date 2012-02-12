//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;

using System.Drawing;

using System.Runtime.InteropServices;

using MonoTouch;

using MonoTouch.CoreFoundation;

using MonoTouch.CoreMedia;

using MonoTouch.CoreMotion;

using MonoTouch.Foundation;

using MonoTouch.ObjCRuntime;

using MonoTouch.CoreAnimation;

using MonoTouch.CoreLocation;

using MonoTouch.MapKit;

using MonoTouch.UIKit;

using MonoTouch.CoreGraphics;

using MonoTouch.NewsstandKit;

using MonoTouch.GLKit;

using OpenTK;

namespace AlexTouch.GoogleAdMobAds {
	[Register("GADInterstitialDelegate", true)]
	public partial class GADInterstitialDelegate : NSObject {
		static IntPtr selInterstitialDidReceiveAd_ = Selector.GetHandle ("interstitialDidReceiveAd:");
		static IntPtr selInterstitialDidFailToReceiveAdWithError_ = Selector.GetHandle ("interstitial:didFailToReceiveAdWithError:");
		static IntPtr selInterstitialWillPresentScreen_ = Selector.GetHandle ("interstitialWillPresentScreen:");
		static IntPtr selInterstitialWillDismissScreen_ = Selector.GetHandle ("interstitialWillDismissScreen:");
		static IntPtr selInterstitialDidDismissScreen_ = Selector.GetHandle ("interstitialDidDismissScreen:");
		static IntPtr selInterstitialWillLeaveApplication_ = Selector.GetHandle ("interstitialWillLeaveApplication:");
		
		static IntPtr class_ptr = Class.GetHandle ("GADInterstitialDelegate");
		
		[Export ("init")]
		public  GADInterstitialDelegate () : base (NSObjectFlag.Empty)
		{
			Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			
		}

		public GADInterstitialDelegate (NSObjectFlag t) : base (t) {}

		public GADInterstitialDelegate (IntPtr handle) : base (handle) {}

		[Export ("interstitialDidReceiveAd:")]
		public virtual void DidReceiveAd (GADInterstitial sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selInterstitialDidReceiveAd_, sender.Handle);
		}
		
		[Export ("interstitial:didFailToReceiveAdWithError:")]
		public virtual void DidFailToReceiveAdWithError (GADInterstitial sender, GADRequestError error)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (error == null)
				throw new ArgumentNullException ("error");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selInterstitialDidFailToReceiveAdWithError_, sender.Handle, error.Handle);
		}
		
		[Export ("interstitialWillPresentScreen:")]
		public virtual void WillPresentScreen (GADInterstitial sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selInterstitialWillPresentScreen_, sender.Handle);
		}
		
		[Export ("interstitialWillDismissScreen:")]
		public virtual void WillDismissScreen (GADInterstitial sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selInterstitialWillDismissScreen_, sender.Handle);
		}
		
		[Export ("interstitialDidDismissScreen:")]
		public virtual void DidDismissScreen (GADInterstitial sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selInterstitialDidDismissScreen_, sender.Handle);
		}
		
		[Export ("interstitialWillLeaveApplication:")]
		public virtual void WillLeaveApplication (GADInterstitial sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selInterstitialWillLeaveApplication_, sender.Handle);
		}
		
	} /* class GADInterstitialDelegate */
}
