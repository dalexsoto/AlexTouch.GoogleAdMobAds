all: docs/en/index.xml

docs/en/index.xml : bin/Release/AlexTouch.GoogleAdMobAds.dll
	mdoc update -L /Library/Frameworks/Mono.framework/Versions/Current/lib/mono/2.0 -L /Developer/MonoTouch/usr/lib/mono/2.1 -o docs/en $< 
