using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
public class AdmobBanner : MonoBehaviour
{
    private string _BanneradUnitId = "ca-app-pub-7933393775749899/5490231878";
    BannerView _bannerView;
    void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {
            LoadBannerAd();
        });

    }

    public void CreateBannerView()
    {
        _bannerView = new BannerView(_BanneradUnitId, AdSize.Banner, AdPosition.Bottom);
        
    }
    public void LoadBannerAd()
    {
        if (_bannerView == null)
        {
            CreateBannerView();
        }
        var adRequest = new AdRequest();
        _bannerView.LoadAd(adRequest);
    }
}
