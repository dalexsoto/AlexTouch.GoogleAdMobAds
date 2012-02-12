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
	[Register("GADBannerView", true)]
	public partial class GADBannerView : MonoTouch.UIKit.UIView {
		static IntPtr selAdUnitID = Selector.GetHandle ("adUnitID");
		static IntPtr selSetAdUnitID_ = Selector.GetHandle ("setAdUnitID:");
		static IntPtr selRootViewController = Selector.GetHandle ("rootViewController");
		static IntPtr selSetRootViewController_ = Selector.GetHandle ("setRootViewController:");
		static IntPtr selDelegate = Selector.GetHandle ("delegate");
		static IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		static IntPtr selHasAutoRefreshed = Selector.GetHandle ("hasAutoRefreshed");
		static IntPtr selLoadRequest_ = Selector.GetHandle ("loadRequest:");
		static IntPtr selInitWithFrame_ = Selector.GetHandle ("initWithFrame:");
		
		static IntPtr class_ptr = Class.GetHandle ("GADBannerView");
		
		[Export ("init")]
		public  GADBannerView () : base (NSObjectFlag.Empty)
		{
			Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			
		}

		public GADBannerView (NSObjectFlag t) : base (t) {}

		public GADBannerView (IntPtr handle) : base (handle) {}

		[Export ("loadRequest:")]
		public virtual void LoadRequest (GADRequest request)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selLoadRequest_, request == null ? IntPtr.Zero : request.Handle);
		}
		
		[Export ("initWithFrame:")]
		public GADBannerView (System.Drawing.RectangleF frame) : base (NSObjectFlag.Empty)
		{
			Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF (this.Handle, selInitWithFrame_, frame);
		}
		
		public virtual string AdUnitID {
			[Export ("adUnitID", ArgumentSemantic.Copy)]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAdUnitID));
			}
			
			[Export ("setAdUnitID:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = new NSString (value);
				
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAdUnitID_, nsvalue.Handle);
				nsvalue.Dispose ();
				
			}
		}
		
		object __mt_RootViewController_var;
		public virtual MonoTouch.UIKit.UIViewController RootViewController {
			[Export ("rootViewController", ArgumentSemantic.Assign)]
			get {
				MonoTouch.UIKit.UIViewController ret;
				ret = (MonoTouch.UIKit.UIViewController) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRootViewController));
				MarkDirty ();
				__mt_RootViewController_var = ret;
				return ret;
			}
			
			[Export ("setRootViewController:", ArgumentSemantic.Assign)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRootViewController_, value.Handle);
				MarkDirty ();
				__mt_RootViewController_var = value;
			}
		}
		
		public GADBannerViewDelegate Delegate {
			get { return WeakDelegate as GADBannerViewDelegate; }
			set { WeakDelegate = value; }
		}
		
		object __mt_WeakDelegate_var;
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegate));
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_, value == null ? IntPtr.Zero : value.Handle);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		public virtual bool HasAutoRefreshed {
			[Export ("hasAutoRefreshed")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasAutoRefreshed);
			}
			
		}
		
		//
		// Events and properties from the delegate
		//
		
		_GADBannerViewDelegate EnsureGADBannerViewDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _GADBannerViewDelegate))){
				del = new _GADBannerViewDelegate ();
				WeakDelegate = del;
			}
			return (_GADBannerViewDelegate) del;
		}
		
		[Register]
		class _GADBannerViewDelegate : AlexTouch.GoogleAdMobAds.GADBannerViewDelegate { 
			public _GADBannerViewDelegate () {}
			
			internal EventHandler didReceiveAd;
			[Preserve (Conditional = true)]
			public override Void DidReceiveAd (AlexTouch.GoogleAdMobAds.GADBannerView sender)
			{
				if (didReceiveAd != null){
					didReceiveAd (sender, EventArgs.Empty);
				}
			}
			
			internal EventHandler<GADBannerViewDidFailWithErrorEventArgs> didFailToReceiveAdWithError;
			[Preserve (Conditional = true)]
			public override Void DidFailToReceiveAdWithError (AlexTouch.GoogleAdMobAds.GADBannerView sender, AlexTouch.GoogleAdMobAds.GADRequestError error)
			{
				if (didFailToReceiveAdWithError != null){
					var args = new GADBannerViewDidFailWithErrorEventArgs (error);
					didFailToReceiveAdWithError (sender, args);
				}
			}
			
			internal EventHandler willPresentScreen;
			[Preserve (Conditional = true)]
			public override Void WillPresentScreen (AlexTouch.GoogleAdMobAds.GADBannerView sender)
			{
				if (willPresentScreen != null){
					willPresentScreen (sender, EventArgs.Empty);
				}
			}
			
			internal EventHandler willDismissScreen;
			[Preserve (Conditional = true)]
			public override Void WillDismissScreen (AlexTouch.GoogleAdMobAds.GADBannerView sender)
			{
				if (willDismissScreen != null){
					willDismissScreen (sender, EventArgs.Empty);
				}
			}
			
			internal EventHandler didDismissScreen;
			[Preserve (Conditional = true)]
			public override Void DidDismissScreen (AlexTouch.GoogleAdMobAds.GADBannerView sender)
			{
				if (didDismissScreen != null){
					didDismissScreen (sender, EventArgs.Empty);
				}
			}
			
			internal EventHandler willLeaveApplication;
			[Preserve (Conditional = true)]
			public override Void WillLeaveApplication (AlexTouch.GoogleAdMobAds.GADBannerView sender)
			{
				if (willLeaveApplication != null){
					willLeaveApplication (sender, EventArgs.Empty);
				}
			}
			
		}
		
		public event EventHandler DidReceiveAd {
			add { EnsureGADBannerViewDelegate ().didReceiveAd += value; }
			remove { EnsureGADBannerViewDelegate ().didReceiveAd -= value; }
		}
		
		public event EventHandler<GADBannerViewDidFailWithErrorEventArgs> DidFailToReceiveAdWithError {
			add { EnsureGADBannerViewDelegate ().didFailToReceiveAdWithError += value; }
			remove { EnsureGADBannerViewDelegate ().didFailToReceiveAdWithError -= value; }
		}
		
		public event EventHandler WillPresentScreen {
			add { EnsureGADBannerViewDelegate ().willPresentScreen += value; }
			remove { EnsureGADBannerViewDelegate ().willPresentScreen -= value; }
		}
		
		public event EventHandler WillDismissScreen {
			add { EnsureGADBannerViewDelegate ().willDismissScreen += value; }
			remove { EnsureGADBannerViewDelegate ().willDismissScreen -= value; }
		}
		
		public event EventHandler DidDismissScreen {
			add { EnsureGADBannerViewDelegate ().didDismissScreen += value; }
			remove { EnsureGADBannerViewDelegate ().didDismissScreen -= value; }
		}
		
		public event EventHandler WillLeaveApplication {
			add { EnsureGADBannerViewDelegate ().willLeaveApplication += value; }
			remove { EnsureGADBannerViewDelegate ().willLeaveApplication -= value; }
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_RootViewController_var = null;
			__mt_WeakDelegate_var = null;
			base.Dispose (disposing);
		}
	} /* class GADBannerView */
	
	
	//
	// EventArgs classes
	//
	public partial class GADBannerViewDidFailWithErrorEventArgs : EventArgs {
		public GADBannerViewDidFailWithErrorEventArgs (AlexTouch.GoogleAdMobAds.GADRequestError error)
		{
			this.Error = error;
		}
		public AlexTouch.GoogleAdMobAds.GADRequestError Error { get; set; }
	}
	
}
