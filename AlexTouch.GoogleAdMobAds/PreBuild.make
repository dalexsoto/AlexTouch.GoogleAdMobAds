all: libGoogleAdMobAds.a

googleadmobadssdkios.zip: 
	curl http://dl.google.com/googleadmobadssdk/googleadmobadssdkios.zip > $@

libGoogleAdMobAds.a: googleadmobadssdkios.zip
	unzip -p $< \*$@ > $@

clean:
	-rm -rf *.a

