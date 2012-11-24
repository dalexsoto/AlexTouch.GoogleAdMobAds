ADMOB_ZIP=googleadmobadssdkios.zip
ADMOB_URL="http://dl.google.com/googleadmobadssdk/$(ADMOB_ZIP)"

all: libGoogleAdMobAds.a

$(ADMOB_ZIP): 
	curl -o $(ADMOB_ZIP) $(ADMOB_URL) 

libGoogleAdMobAds.a: $(ADMOB_ZIP)
	unzip -p $< \*$@ > $@

clean:
	-rm -rf *.a *.zip

