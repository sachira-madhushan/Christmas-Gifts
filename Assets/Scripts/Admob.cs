using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;
using System;

public class Admob : MonoBehaviour
{

    private string _adUnitId = "ca-app-pub-7933393775749899/8643008821";
    private RewardedAd _rewardedAd;

    void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {
            LoadRewardedAd();

        });

        
    }

    
    public void LoadRewardedAd()
    {
        if (_rewardedAd != null)
        {
            _rewardedAd.Destroy();
            _rewardedAd = null;
        }

        var adRequest = new AdRequest();
        RewardedAd.Load(_adUnitId, adRequest,
            (RewardedAd ad, LoadAdError error) =>
            {
              if (error != null || ad == null)
                {
                    return;
                }
                _rewardedAd = ad;
            });
    }
    public void ShowRewardedAd()
    {

        if (_rewardedAd != null && _rewardedAd.CanShowAd())
        {
            _rewardedAd.Show((Reward reward) =>
            {
                LoadRewardedAd();
            });
        }

    }
}
