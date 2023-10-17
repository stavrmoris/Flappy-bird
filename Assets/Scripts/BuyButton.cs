using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyButton : MonoBehaviour
{
    public Coins coinsMananger;
    public int price;
    public float id;

    void Start()
    {
        coinsMananger = GameObject.Find("CoinsMananger").GetComponent<Coins>();
        if (PlayerPrefs.GetInt("BuyButton" + id) == 1) 
            gameObject.SetActive(false);
    }

    public void Buy()
    {
        if (coinsMananger.coins >= price)
        {   
            PlayerPrefs.SetInt("BuyButton" + id, 1);
            coinsMananger.coins -= price;
            PlayerPrefs.SetInt("Coins", coinsMananger.coins);
            gameObject.SetActive(false);
        }
    }
}
