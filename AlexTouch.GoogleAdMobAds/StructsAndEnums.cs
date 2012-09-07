using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using System.Runtime.InteropServices;
using MonoTouch.Foundation;

//GADRequest file	
public enum GADGender 
{	
	Unknown,
	Male,
	Female
}

//GADRequestError file
public enum GADErrorCode 
{	
	InvalidRequest,
	NoFill,
	NetworkError,
	ServerError,
	OSVersionTooLow,
	Timeout,
	InterstitialAlreadyUsed,
	MediationDataError,
	MediationAdapterError,
	MediationNoFill,
	MediationInvalidAdSize
}

public enum GADSearchBorderType 
{	
	None,
	Dashed,
	Dotted,
	Solid
}

public struct GADAdSize
{
	public SizeF size;
	public uint flags;
}

public partial class GADAdSizeCons
{	
	#region " SizeConstants "
	public static GADAdSize Banner 
	{
		get 
		{
			IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
			IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "MTAdSizeBanner");
			object obj = Marshal.PtrToStructure(ptr, typeof(GADAdSize));
			
			return (GADAdSize)obj;
		}
	}
	
	public static GADAdSize MediumRectangle 
	{
		get 
		{
			IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
			IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "MTGADAdSizeMediumRectangle");
			object obj = Marshal.PtrToStructure(ptr, typeof(GADAdSize));
			
			return (GADAdSize)obj;
		}
	}
	
	public static GADAdSize FullBanner 
	{
		get 
		{
			IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
			IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "MTGADAdSizeFullBanner");
			object obj = Marshal.PtrToStructure(ptr, typeof(GADAdSize));
			
			return (GADAdSize)obj;
		}
	}
	
	public static GADAdSize Leaderboard 
	{
		get 
		{
			IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
			IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "MTGADAdSizeLeaderboard");
			object obj = Marshal.PtrToStructure(ptr, typeof(GADAdSize));
			
			return (GADAdSize)obj;
		}
	}
	
	public static GADAdSize Skyscraper 
	{
		get 
		{
			IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
			IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "MTGADAdSizeSkyscraper");
			object obj = Marshal.PtrToStructure(ptr, typeof(GADAdSize));
			
			return (GADAdSize)obj;
		}
	}
	
	public static GADAdSize SmartBannerPortrait 
	{
		get 
		{
			IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
			IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "MTGADAdSizeSmartBannerPortrait");
			object obj = Marshal.PtrToStructure(ptr, typeof(GADAdSize));
			
			return (GADAdSize)obj;
		}
	}
	
	public static GADAdSize SmartBannerLandscape 
	{
		get 
		{
			IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
			IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "MTGADAdSizeSmartBannerLandscape");
			object obj = Marshal.PtrToStructure(ptr, typeof(GADAdSize));
			
			return (GADAdSize)obj;
		}
	}
	
	public static GADAdSize Invalid 
	{
		get 
		{
			IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
			IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "MTGADAdSizeInvalid");
			object obj = Marshal.PtrToStructure(ptr, typeof(GADAdSize));
			
			return (GADAdSize)obj;
		}
	}
	
#endregion
	
	#region "Convenience Functions"
	
	// Deprecated Macros
	[Obsolete("Use GADAdSizeCons.Banner Instead")]
	public static readonly SizeF GAD_SIZE_320x50 = GADAdSizeCons.Banner.size;
	
	[Obsolete("Use GADAdSizeCons.MediumRectangle Instead")]
	public static readonly SizeF GAD_SIZE_300x250 = GADAdSizeCons.MediumRectangle.size;
	
	[Obsolete("Use ADAdSizeCons.FullBanner Instead")]
	public static readonly SizeF GAD_SIZE_468x60 = GADAdSizeCons.FullBanner.size;
	
	[Obsolete("Use GADAdSizeCons.Leaderboard Instead")]
	public static readonly SizeF GAD_SIZE_728x90 = GADAdSizeCons.Leaderboard.size;
	
	[Obsolete("Use ADAdSizeCons.Skyscraper Instead")]
	public static readonly SizeF GAD_SIZE_120x600 = GADAdSizeCons.Skyscraper.size;

	#endregion

}

