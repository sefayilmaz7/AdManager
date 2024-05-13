using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdTest : MonoBehaviour
{
    [SerializeField] private AdManager AdManager;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Show ad
            AdManager.ShowRewardedAd();
        }
    }
}
