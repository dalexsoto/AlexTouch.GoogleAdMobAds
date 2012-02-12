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
	[Register("GADBannerViewDelegate", true)]
	public partial class GADBannerViewDelegate : NSObject {
		static IntPtr selAdViewDidReceiveAd_ = Selector.GetHandle ("adViewDidReceiveAd:");
		static IntPtr selAdViewDidFailToReceiveAdWithError_ = Selector.GetHandle ("adView:didFailToReceiveAdWithError:");
		static IntPtr selAdViewWillPresentScreen_ = Selector.GetHandle ("adViewWillPresentScreen:");
		static IntPtr selAdViewWillDismissScreen_ = Selector.GetHandle ("adViewWillDismissScreen:");
		static IntPtr selAdViewDidDismissScreen_ = Selector.GetHandle ("adViewDidDismissScreen:");
		static IntPtr selAdViewWillLeaveApplication_ = Selector.GetHandle ("adViewWillLeaveApplication:");
		
		static IntPtr class_ptr = Class.GetHandle ("GADBannerViewDelegate");
		
		[Export ("init")]
		public  GADBannerViewDelegate () : base (NSObjectFlag.Empty)
		{
			Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			
		}

		public GADBannerViewDelegate (NSObjectFlag t) : base (t) {}

		public GADBannerViewDelegate (IntPtr handle) : base (handle) {}

		[Export ("adViewDidReceiveAd:")]
		public virtual void DidReceiveAd (GADBannerView sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAdViewDidReceiveAd_, sender.Handle);
		}
		
		[Export ("adView:didFailToReceiveAdWithError:")]
		public virtual void DidFailToReceiveAdWithError (GADBannerView sender, GADRequestError error)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (error == null)
				throw new ArgumentNullException ("error");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selAdViewDidFailToReceiveAdWithError_, sender.Handle, error.Handle);
		}
		
		[Export ("adViewWillPresentScreen:")]
		public virtual void WillPresentScreen (GADBannerView sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAdViewWillPresentScreen_, sender.Handle);
		}
		
		[Export ("adViewWillDismissScreen:")]
		public virtual void WillDismissScreen (GADBannerView sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAdViewWillDismissScreen_, sender.Handle);
		}
		
		[Export ("adViewDidDismissScreen:")]
		public virtual void DidDismissScreen (GADBannerView sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAdViewDidDismissScreen_, sender.Handle);
		}
		
		[Export ("adViewWillLeaveApplication:")]
		public virtual void WillLeaveApplication (GADBannerView sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAdViewWillLeaveApplication_, sender.Handle);
		}
		
	} /* class GADBannerViewDelegate */
}
