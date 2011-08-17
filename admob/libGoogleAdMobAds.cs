using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;

namespace libGoogleAdMobAds
{	
	//@interface GADBannerView : UIView
	[BaseType (typeof (UIView))]
	interface GADBannerView
	{
		//@property (nonatomic, copy) NSString *adUnitID;
		[Export ("adUnitID", ArgumentSemantic.Copy)]
    	string AdUnitID { get; set; }
		
		//@property (nonatomic, assign) UIViewController *rootViewController;
		[Export ("rootViewController", ArgumentSemantic.Assign)]
		UIViewController RootViewController {get; set; }
		
		//@property (nonatomic, assign) NSObject<GADBannerViewDelegate> *delegate;
		[Wrap ("WeakDelegate")] 
	    GADBannerViewDelegate Delegate { get; set; }
		
		//@property (nonatomic, assign) NSObject<GADBannerViewDelegate> *delegate;
	    [Export ("delegate", ArgumentSemantic.Assign), NullAllowed]
	    NSObject WeakDelegate { get; set; }
		
		//- (void)loadRequest:(GADRequest *)request;
		[Export ("loadRequest:")]
    	void LoadRequest( [NullAllowed] GADRequest request);
		
		//@property (nonatomic, readonly) BOOL hasAutoRefreshed;
		[Export ("hasAutoRefreshed")]
    	bool HasAutoRefreshed { get; }
		
		[Export ("initWithFrame:")]
		IntPtr Constructor (RectangleF frame);
	}
	
	//@protocol GADBannerViewDelegate <NSObject>
	[BaseType (typeof (NSObject))]
  	[Model]
	interface GADBannerViewDelegate 
	{
		//- (void)adViewDidReceiveAd:(GADBannerView *)view;
		[Export ("adViewDidReceiveAd:")]
		void AdViewDidReceiveAd(GADBannerView view);
		
//		//- (void)adView:(GADBannerView *)view didFailToReceiveAdWithError:(GADRequestError *)error;
//		[Export ("adView:didFailToReceiveAdWithError:")]
//		void AdView(GADBannerView view, GADRequestError error);
		
		//- (void)adViewWillPresentScreen:(GADBannerView *)adView;
		[Export ("adViewWillPresentScreen:")]
		void AdViewWillPresentScreen(GADBannerView adView);
		
		//- (void)adViewWillDismissScreen:(GADBannerView *)adView;
		[Export ("adViewWillDismissScreen:")]
		void AdViewWillDismissScreen(GADBannerView adView);
		
		//- (void)adViewDidDismissScreen:(GADBannerView *)adView;
		[Export ("adViewDidDismissScreen:")]
		void AdViewDidDismissScreen(GADBannerView adView);
		
		//- (void)adViewWillLeaveApplication:(GADBannerView *)adView;
		[Export ("adViewWillLeaveApplication:")]
		void adViewWillLeaveApplication(GADBannerView adView);
	}
	
	//@interface GADInterstitial : NSObject
	[BaseType (typeof (NSObject))]
	interface GADInterstitial
	{
		//@property (nonatomic, copy) NSString *adUnitID;
		[Export ("adUnitID", ArgumentSemantic.Copy)]
    	string AdUnitID { get; set; }
		
		//@property (nonatomic, assign) NSObject<GADInterstitialDelegate> *delegate;
		[Wrap ("WeakDelegate")] 
	    GADInterstitialDelegate Delegate { get; set; }
		
		//@property (nonatomic, assign) NSObject<GADInterstitialDelegate> *delegate;
	    [Export ("delegate", ArgumentSemantic.Assign), NullAllowed]
	    NSObject WeakDelegate { get; set; }
		
		//- (void)loadRequest:(GADRequest *)request;
		[Export ("loadRequest:")]
		void LoadRequest(GADRequest request);
		
		//- (void)loadAndDisplayRequest:(GADRequest *)request usingWindow:(UIWindow *)window initialImage:(UIImage *)image;
		[Export ("loadAndDisplayRequest:usingWindow:initialImage:")]
		void LoadAndDisplayRequest(GADRequest request, UIWindow window, UIImage image);
		
		//@property (nonatomic, readonly) BOOL isReady;
		[Export ("isReady")]
		bool IsReady { get; }
		
		//- (void)presentFromRootViewController:(UIViewController *)rootViewController;
		[Export ("presentFromRootViewController:")]
		void PresentFromRootViewController(UIViewController rootViewController);
	}
	
	//@protocol GADInterstitialDelegate <NSObject>
	[BaseType (typeof (NSObject))]
  	[Model]
	interface GADInterstitialDelegate 
	{
		//- (void)interstitialDidReceiveAd:(GADInterstitial *)ad;
		[Export ("interstitialDidReceiveAd:")]
		void interstitialDidReceiveAd(GADInterstitial ad);
		
//		//- (void)interstitial:(GADInterstitial *)ad didFailToReceiveAdWithError:(GADRequestError *)error;
//		[Export ("interstitial:didFailToReceiveAdWithError:")]
//		void Interstitial(GADInterstitial ad, GADRequestError error);
		
		//- (void)interstitialWillPresentScreen:(GADInterstitial *)ad;
		[Export ("interstitialWillPresentScreen:")]
		void InterstitialWillPresentScreen(GADInterstitial ad);
		
		//- (void)interstitialWillDismissScreen:(GADInterstitial *)ad;
		[Export ("interstitialWillDismissScreen:")]
		void InterstitialWillDismissScreen(GADInterstitial ad);
		
		//- (void)interstitialDidDismissScreen:(GADInterstitial *)ad;
		[Export ("interstitialDidDismissScreen:")]
		void InterstitialDidDismissScreen(GADInterstitial ad);
		
		//- (void)interstitialWillLeaveApplication:(GADInterstitial *)ad;
		[Export ("interstitialWillLeaveApplication:")]
		void InterstitialWillLeaveApplication(GADInterstitial ad);
		
	}
	
	//@interface GADRequest : NSObject <NSCopying>
	[BaseType (typeof (NSObject))]
	interface GADRequest
	{
		//+ (GADRequest *)request;
		[Static, Export ("request")]
		GADRequest Request();
		
		//@property (nonatomic, retain) NSDictionary *additionalParameters;
		[Export ("additionalParameters", ArgumentSemantic.Retain)]
		NSDictionary AdditionalParameters { get; set; }
		
		//+ (NSString *)sdkVersion;
		[Static, Export ("sdkVersion")]
		string SdkVersion();
		
		//@property (nonatomic, retain) NSArray *testDevices;
		[Export ("testDevices", ArgumentSemantic.Retain)]
		string [] TestDevices { get; set; }
		
		//@property (nonatomic, assign) GADGender gender;
		[Export ("gender", ArgumentSemantic.Assign)]
		GADGender Gender { get; set; }
		
		//@property (nonatomic, retain) NSDate *birthday;
		[Export ("birthday", ArgumentSemantic.Retain)]
		NSDate Birthday { get; set; } 
		
		//- (void)setBirthdayWithMonth:(NSInteger)m day:(NSInteger)d year:(NSInteger)y;
		[Export ("setBirthdayWithMonth:day:year:")]
		void SetBirthda(int m, int d, int y);
		
		//- (void)setLocationWithLatitude:(CGFloat)latitude longitude:(CGFloat)longitude accuracy:(CGFloat)accuracyInMeters;
		[Export ("setLocationWithLatitude:longitude:accuracy:")]
		void SetLocationy(float latitude, float longitude, float accuracyInMeters);
		
		//- (void)setLocationWithDescription:(NSString *)locationDescription;
		[Export ("setLocationWithDescription:")]
		void SetLocationWithDescription(string locationDescription);
		
		//@property (nonatomic, retain) NSMutableArray *keywords;
		[Export ("keywords", ArgumentSemantic.Retain), NullAllowed]
		string [] keywords { get; set; }
		
		//- (void)addKeyword:(NSString *)keyword;
		[Export ("addKeyword:")]
		void AddKeyword (string keyword);
		
		//@property (nonatomic, getter=isTesting) BOOL testing;
		[Export ("testing")]
		bool Testing {  [Bind ("isTesting")] get; set; }
	}
	
//	[Static]
//	[BaseType (typeof (NSError))]
//	interface GADRequestError 
//	{
//	    [Field ("kGADErrorDomain")]
//	    NSString kGADErrorDomain { get; set; }
//	}
	
	
//	this is the only missing stuff not bound 
//
//
//#import <Foundation/Foundation.h>
//
//@class GADRequest;
//
//extern NSString *kGADErrorDomain;
//
//// NSError codes for GAD error domain.
//typedef enum {
//  // The ad request is invalid.  The localizedFailureReason error description
//  // will have more details.  Typically this is because the ad did not have the
//  // ad unit ID or root view controller set.
//  kGADErrorInvalidRequest,
//
//  // The ad request was successful, but no ad was returned.
//  kGADErrorNoFill,
//
//  // There was an error loading data from the network.
//  kGADErrorNetworkError,
//
//  // The ad server experienced a failure processing the request.
//  kGADErrorServerError,
//
//  // The current device's OS is below the minimum required version.
//  kGADErrorOSVersionTooLow,
//
//  // The request was unable to be loaded before being timed out.
//  kGADErrorTimeout,
//
//} GADErrorCode;
//
//// This class represents the error generated due to invalid request parameters.
//@interface GADRequestError : NSError
//
//@end
	
}

