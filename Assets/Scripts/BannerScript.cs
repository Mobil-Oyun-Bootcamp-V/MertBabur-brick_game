using System;
using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds.Api;
using UnityEngine;

public class BannerScript : MonoBehaviour
{
    private BannerView _banner;

    public String _bannerID = "ca-app-pub-3940256099942544/6300978111";

    // Start is called before the first frame update
    void Start()
    {
        _banner = new BannerView(_bannerID, AdSize.Banner, AdPosition.Bottom);
        AdRequest adReq = new AdRequest.Builder().Build();
        _banner.LoadAd(adReq);
        
        _banner.Show();
    }

    
}
