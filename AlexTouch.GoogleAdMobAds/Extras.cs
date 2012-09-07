using System;
using MonoTouch.ObjCRuntime;
using System.Runtime.InteropServices;
using MonoTouch.Foundation;

namespace AlexTouch.GoogleAdMobAds
{
	public partial class GADRequest
	{
		public static readonly string GAD_SIMULATOR_ID = "Simulator";
		
		public static readonly string GADGoogleAdMobNetworkName = "GoogleAdMobAds";
	}

	public partial class GADRequestError
	{
		private static string kGADErrorDomain;
		
		public static string ErrorDomain
		{
			get 
			{
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				kGADErrorDomain = (string) Dlfcn.GetStringConstant (RTLD_MAIN_ONLY, "kGADErrorDomain");
				
				return kGADErrorDomain;
			}
			set 
			{
				kGADErrorDomain = value;
				
				IntPtr RTLD_MAIN_ONLY = Dlfcn.dlopen (null, 0);
				IntPtr ptr = Dlfcn.dlsym (RTLD_MAIN_ONLY, "kGADErrorDomain");
				
				Marshal.WriteIntPtr(ptr, new NSString(kGADErrorDomain).Handle);
				
			}
		}
	}

}

