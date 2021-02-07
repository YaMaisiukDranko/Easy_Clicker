using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
//using GoogleMobileAds.Api;
//using GoogleMobileAds.Common;

public class Game : MonoBehaviour
{
    public int Money;
    private int MoneyUp = 1;

    private bool Check = true;
    public Text MoneyText;
    public GameObject ShopPan;


    void Start()
    {

    }



    void Update()
    {
        MoneyText.text = Money + "";
    }

    public void OnClickButton()
    {
        Money += MoneyUp;
        PlayerPrefs.SetInt("Money+",Money);
    }

    /*public void OnClickShopButton()
    {
        if (Check == true)
        {
            ShopPan.SetActive(true);
            Check = false;
        }
        else
        {
            ShopPan.SetActive(false);
            Check = true;
        }
    }
        

    public void OnClickBuy()
    {

        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
        }
    }
*/
}
