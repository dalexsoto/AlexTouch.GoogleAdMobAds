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
	[Register("GADInterstitial", true)]
	public partial class GADInterstitial : NSObject {
		static IntPtr selAdUnitID = Selector.GetHandle ("adUnitID");
		static IntPtr selSetAdUnitID_ = Selector.GetHandle ("setAdUnitID:");
		static IntPtr selDelegate = Selector.GetHandle ("delegate");
		static IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		static IntPtr selIsReady = Selector.GetHandle ("isReady");
		static IntPtr selHasBeenUsed = Selector.GetHandle ("hasBeenUsed");
		static IntPtr selLoadRequest_ = Selector.GetHandle ("loadRequest:");
		static IntPtr selLoadAndDisplayRequestUsingWindowInitialImage_ = Selector.GetHandle ("loadAndDisplayRequest:usingWindow:initialImage:");
		static IntPtr selPresentFromRootViewController_ = Selector.GetHandle ("presentFromRootViewController:");
		
		static IntPtr class_ptr = Class.GetHandle ("GADInterstitial");
		
		[Export ("init")]
		public  GADInterstitial () : base (NSObjectFlag.Empty)
		{
			Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			
		}

		public GADInterstitial (NSObjectFlag t) : base (t) {}

		public GADInterstitial (IntPtr handle) : base (handle) {}

		[Export ("loadRequest:")]
		public virtual void LoadRequest (GADRequest request)
		{
			if (request == null)
				throw new ArgumentNullException ("request");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selLoadRequest_, request.Handle);
		}
		
		[Export ("loadAndDisplayRequest:usingWindow:initialImage:")]
		public virtual void LoadAndDisplayRequest (GADRequest request, MonoTouch.UIKit.UIWindow window, MonoTouch.UIKit.UIImage image)
		{
			if (request == null)
				throw new ArgumentNullException ("request");
			if (window == null)
				throw new ArgumentNullException ("window");
			if (image == null)
				throw new ArgumentNullException ("image");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selLoadAndDisplayRequestUsingWindowInitialImage_, request.Handle, window.Handle, image.Handle);
		}
		
		[Export ("presentFromRootViewController:")]
		public virtual void PresentFromRootViewController (MonoTouch.UIKit.UIViewController rootViewController)
		{
			if (rootViewController == null)
				throw new ArgumentNullException ("rootViewController");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selPresentFromRootViewController_, rootViewController.Handle);
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
		
		public GADInterstitialDelegate Delegate {
			get { return WeakDelegate as GADInterstitialDelegate; }
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
		
		public virtual bool IsReady {
			[Export ("isReady")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsReady);
			}
			
		}
		
		public virtual bool HasBeenUsed {
			[Export ("hasBeenUsed")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasBeenUsed);
			}
			
		}
		
		//
		// Events and properties from the delegate
		//
		
		_GADInterstitialDelegate EnsureGADInterstitialDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _GADInterstitialDelegate))){
				del = new _GADInterstitialDelegate ();
				WeakDelegate = del;
			}
			return (_GADInterstitialDelegate) del;
		}
		
		[Register]
		class _GADInterstitialDelegate : AlexTouch.GoogleAdMobAds.GADInterstitialDelegate { 
			public _GADInterstitialDelegate () {}
			
			internal EventHandler didReceiveAd;
			[Preserve (Conditional = true)]
			public override Void DidReceiveAd (AlexTouch.GoogleAdMobAds.GADInterstitial sender)
			{
				if (didReceiveAd != null){
					didReceiveAd (sender, EventArgs.Empty);
				}
			}
			
			internal EventHandler<GADInterstitialDidFailToReceiveAdWithErrorEventArgs> didFailToReceiveAdWithError;
			[Preserve (Conditional = true)]
			public override Void DidFailToReceiveAdWithError (AlexTouch.GoogleAdMobAds.GADInterstitial sender, AlexTouch.GoogleAdMobAds.GADRequestError error)
			{
				if (didFailToReceiveAdWithError != null){
					var args = new GADInterstitialDidFailToReceiveAdWithErrorEventArgs (error);
					didFailToReceiveAdWithError (sender, args);
				}
			}
			
			internal EventHandler willPresentScreen;
			[Preserve (Conditional = true)]
			public override Void WillPresentScreen (AlexTouch.GoogleAdMobAds.GADInterstitial sender)
			{
				if (willPresentScreen != null){
					willPresentScreen (sender, EventArgs.Empty);
				}
			}
			
			internal EventHandler willDismissScreen;
			[Preserve (Conditional = true)]
			public override Void WillDismissScreen (AlexTouch.GoogleAdMobAds.GADInterstitial sender)
			{
				if (willDismissScreen != null){
					willDismissScreen (sender, EventArgs.Empty);
				}
			}
			
			internal EventHandler didDismissScreen;
			[Preserve (Conditional = true)]
			public override Void DidDismissScreen (AlexTouch.GoogleAdMobAds.GADInterstitial sender)
			{
				if (didDismissScreen != null){
					didDismissScreen (sender, EventArgs.Empty);
				}
			}
			
			internal EventHandler willLeaveApplication;
			[Preserve (Conditional = true)]
			public override Void WillLeaveApplication (AlexTouch.GoogleAdMobAds.GADInterstitial sender)
			{
				if (willLeaveApplication != null){
					willLeaveApplication (sender, EventArgs.Empty);
				}
			}
			
		}
		
		public event EventHandler DidReceiveAd {
			add { EnsureGADInterstitialDelegate ().didReceiveAd += value; }
			remove { EnsureGADInterstitialDelegate ().didReceiveAd -= value; }
		}
		
		public event EventHandler<GADInterstitialDidFailToReceiveAdWithErrorEventArgs> DidFailToReceiveAdWithError {
			add { EnsureGADInterstitialDelegate ().didFailToReceiveAdWithError += value; }
			remove { EnsureGADInterstitialDelegate ().didFailToReceiveAdWithError -= value; }
		}
		
		public event EventHandler WillPresentScreen {
			add { EnsureGADInterstitialDelegate ().willPresentScreen += value; }
			remove { EnsureGADInterstitialDelegate ().willPresentScreen -= value; }
		}
		
		public event EventHandler WillDismissScreen {
			add { EnsureGADInterstitialDelegate ().willDismissScreen += value; }
			remove { EnsureGADInterstitialDelegate ().willDismissScreen -= value; }
		}
		
		public event EventHandler DidDismissScreen {
			add { EnsureGADInterstitialDelegate ().didDismissScreen += value; }
			remove { EnsureGADInterstitialDelegate ().didDismissScreen -= value; }
		}
		
		public event EventHandler WillLeaveApplication {
			add { EnsureGADInterstitialDelegate ().willLeaveApplication += value; }
			remove { EnsureGADInterstitialDelegate ().willLeaveApplication -= value; }
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_WeakDelegate_var = null;
			base.Dispose (disposing);
		}
	} /* class GADInterstitial */
	
	
	//
	// EventArgs classes
	//
	public partial class GADInterstitialDidFailToReceiveAdWithErrorEventArgs : EventArgs {
		public GADInterstitialDidFailToReceiveAdWithErrorEventArgs (AlexTouch.GoogleAdMobAds.GADRequestError error)
		{
			this.Error = error;
		}
		public AlexTouch.GoogleAdMobAds.GADRequestError Error { get; set; }
	}
	
}
