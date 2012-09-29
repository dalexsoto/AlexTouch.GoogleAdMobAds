using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libGoogleAdMobAds.a", LinkTarget.Simulator | LinkTarget.ArmV7, ForceLoad = true, Frameworks = "AudioToolbox MessageUI SystemConfiguration CoreGraphics MediaPlayer", WeakFrameworks = "AdSupport", IsCxx = true, 
                     LinkerFlags = "-lz -lsqlite3 " +
                     "-Xlinker -alias -Xlinker _kGADAdSizeBanner -Xlinker _MTAdSizeBanner " +
                     "-Xlinker -alias -Xlinker _kGADAdSizeMediumRectangle -Xlinker _MTGADAdSizeMediumRectangle " +
                     "-Xlinker -alias -Xlinker _kGADAdSizeFullBanner -Xlinker _MTGADAdSizeFullBanner " +
                     "-Xlinker -alias -Xlinker _kGADAdSizeLeaderboard -Xlinker _MTGADAdSizeLeaderboard " +
                     "-Xlinker -alias -Xlinker _kGADAdSizeSkyscraper -Xlinker _MTGADAdSizeSkyscraper " +
                     "-Xlinker -alias -Xlinker _kGADAdSizeSmartBannerPortrait -Xlinker _MTGADAdSizeSmartBannerPortrait " +
                     "-Xlinker -alias -Xlinker _kGADAdSizeSmartBannerLandscape -Xlinker _MTGADAdSizeSmartBannerLandscape " +
                     "-Xlinker -alias -Xlinker _kGADAdSizeInvalid -Xlinker _MTGADAdSizeInvalid")]