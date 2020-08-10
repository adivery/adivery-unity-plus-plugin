﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using adivery;

public class MyInterstitialAdCallback : InterstitialAdCallback
{
    public override void onAdLoaded(string adId)
    {
        Adivery.showAd(adId);
    }
}
