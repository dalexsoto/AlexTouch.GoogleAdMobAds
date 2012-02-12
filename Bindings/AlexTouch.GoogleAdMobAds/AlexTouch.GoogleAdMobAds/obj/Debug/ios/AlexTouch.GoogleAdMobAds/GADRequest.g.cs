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
	[Register("GADRequest", true)]
	public partial class GADRequest : NSObject {
		static IntPtr selAdditionalParameters = Selector.GetHandle ("additionalParameters");
		static IntPtr selSetAdditionalParameters_ = Selector.GetHandle ("setAdditionalParameters:");
		static IntPtr selTestDevices = Selector.GetHandle ("testDevices");
		static IntPtr selSetTestDevices_ = Selector.GetHandle ("setTestDevices:");
		static IntPtr selGender = Selector.GetHandle ("gender");
		static IntPtr selSetGender_ = Selector.GetHandle ("setGender:");
		static IntPtr selBirthday = Selector.GetHandle ("birthday");
		static IntPtr selSetBirthday_ = Selector.GetHandle ("setBirthday:");
		static IntPtr selKeywords = Selector.GetHandle ("keywords");
		static IntPtr selSetKeywords_ = Selector.GetHandle ("setKeywords:");
		static IntPtr selIsTesting = Selector.GetHandle ("isTesting");
		static IntPtr selSetTesting_ = Selector.GetHandle ("setTesting:");
		static IntPtr selRequest = Selector.GetHandle ("request");
		static IntPtr selSdkVersion = Selector.GetHandle ("sdkVersion");
		static IntPtr selSetBirthdayWithMonthDayYear_ = Selector.GetHandle ("setBirthdayWithMonth:day:year:");
		static IntPtr selSetLocationWithLatitudeLongitudeAccuracy_ = Selector.GetHandle ("setLocationWithLatitude:longitude:accuracy:");
		static IntPtr selSetLocationWithDescription_ = Selector.GetHandle ("setLocationWithDescription:");
		static IntPtr selAddKeyword_ = Selector.GetHandle ("addKeyword:");
		
		static IntPtr class_ptr = Class.GetHandle ("GADRequest");
		
		[Export ("init")]
		public  GADRequest () : base (NSObjectFlag.Empty)
		{
			Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			
		}

		public GADRequest (NSObjectFlag t) : base (t) {}

		public GADRequest (IntPtr handle) : base (handle) {}

		[Export ("request")]
		public static GADRequest Request ()
		{
			return (GADRequest) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selRequest));
		}
		
		[Export ("sdkVersion")]
		public static string SdkVersion ()
		{
			return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selSdkVersion));
		}
		
		[Export ("setBirthdayWithMonth:day:year:")]
		public virtual void SetBirthday (int m, int d, int y)
		{
			ApiDefinition.Messaging.void_objc_msgSend_int_int_int (this.Handle, selSetBirthdayWithMonthDayYear_, m, d, y);
		}
		
		[Export ("setLocationWithLatitude:longitude:accuracy:")]
		public virtual void SetLocationWithLatitude (float latitude, float longitude, float accuracyInMeters)
		{
			ApiDefinition.Messaging.void_objc_msgSend_float_float_float (this.Handle, selSetLocationWithLatitudeLongitudeAccuracy_, latitude, longitude, accuracyInMeters);
		}
		
		[Export ("setLocationWithDescription:")]
		public virtual void SetLocationWithDescription (string locationDescription)
		{
			if (locationDescription == null)
				throw new ArgumentNullException ("locationDescription");
			var nslocationDescription = new NSString (locationDescription);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLocationWithDescription_, nslocationDescription.Handle);
			nslocationDescription.Dispose ();
			
		}
		
		[Export ("addKeyword:")]
		public virtual void AddKeyword (string keyword)
		{
			if (keyword == null)
				throw new ArgumentNullException ("keyword");
			var nskeyword = new NSString (keyword);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAddKeyword_, nskeyword.Handle);
			nskeyword.Dispose ();
			
		}
		
		object __mt_AdditionalParameters_var;
		public virtual NSDictionary AdditionalParameters {
			[Export ("additionalParameters", ArgumentSemantic.Retain)]
			get {
				NSDictionary ret;
				ret = (NSDictionary) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAdditionalParameters));
				if (!IsNewRefcountEnabled ())
					__mt_AdditionalParameters_var = ret;
				return ret;
			}
			
			[Export ("setAdditionalParameters:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAdditionalParameters_, value.Handle);
				if (!IsNewRefcountEnabled ())
					__mt_AdditionalParameters_var = value;
			}
		}
		
		public virtual System.String[] TestDevices {
			[Export ("testDevices", ArgumentSemantic.Retain)]
			get {
				return NSArray.StringArrayFromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTestDevices));
			}
			
			[Export ("setTestDevices:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromStrings (value);
				
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTestDevices_, nsa_value.Handle);
				nsa_value.Dispose ();
				
			}
		}
		
		public virtual GADGender Gender {
			[Export ("gender", ArgumentSemantic.Assign)]
			get {
				return (GADGender) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selGender);
			}
			
			[Export ("setGender:", ArgumentSemantic.Assign)]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetGender_, (int)value);
			}
		}
		
		object __mt_Birthday_var;
		public virtual NSDate Birthday {
			[Export ("birthday", ArgumentSemantic.Retain)]
			get {
				NSDate ret;
				ret = (NSDate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBirthday));
				if (!IsNewRefcountEnabled ())
					__mt_Birthday_var = ret;
				return ret;
			}
			
			[Export ("setBirthday:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBirthday_, value.Handle);
				if (!IsNewRefcountEnabled ())
					__mt_Birthday_var = value;
			}
		}
		
		public virtual System.String[] keywords {
			[Export ("keywords", ArgumentSemantic.Retain)]
			get {
				return NSArray.StringArrayFromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selKeywords));
			}
			
			[Export ("setKeywords:", ArgumentSemantic.Retain)]
			set {
				var nsa_value = value == null ? null : NSArray.FromStrings (value);
				
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetKeywords_, nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				if (nsa_value != null)
					nsa_value.Dispose ();
				
			}
		}
		
		public virtual bool Testing {
			[Export ("isTesting")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsTesting);
			}
			
			[Export ("setTesting:")]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetTesting_, value);
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_AdditionalParameters_var = null;
			__mt_Birthday_var = null;
			base.Dispose (disposing);
		}
	} /* class GADRequest */
}
