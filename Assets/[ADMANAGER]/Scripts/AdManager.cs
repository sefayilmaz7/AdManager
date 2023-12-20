using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdManager : MonoBehaviour, IAdManager
{
    [SerializeField] private IAdManager adManager;

    private void Awake()
    {
        adManager = this;
    }

    public void ShowInterstitial()
    {
        adManager.ShowInterstitial();
    }

    public void ShowRewarded()
    {
        adManager.ShowRewarded();
    }

    public void ShowRewardedInterstitial()
    {
        adManager.ShowRewardedInterstitial();
    }

    public void ShowBanner()
    {
        adManager.ShowBanner();
    }
}
