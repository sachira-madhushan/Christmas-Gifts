using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
public class AdmobInstaAds : MonoBehaviour
{
    private string _adUnitId = "ca-app-pub-3940256099942544/1033173712";
    private InterstitialAd _interstitialAd;
    void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {
            LoadInterstitialAd();
        });
    }

    void Update()
    {
        
    }
    public void LoadInterstitialAd()
    {
        if (_interstitialAd != null)
        {
            _interstitialAd.Destroy();
            _interstitialAd = null;
        }
        var adRequest = new AdRequest();
        InterstitialAd.Load(_adUnitId, adRequest,
            (InterstitialAd ad, LoadAdError error) =>
            {
              if (error != null || ad == null)
                {
                    Debug.LogError("interstitial ad failed to load an ad " +
                                   "with error : " + error);
                    return;
                }

                Debug.Log("Interstitial ad loaded with response : "
                          + ad.GetResponseInfo());

                _interstitialAd = ad;
            });
    }

    public void ShowInterstitialAd()
    {
        if (_interstitialAd != null && _interstitialAd.CanShowAd())
        {
            
            _interstitialAd.Show();
        }
        else
        {
            
        }
    }
}
