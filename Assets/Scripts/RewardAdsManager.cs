using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
using TMPro;

public class RewardAdsManager : MonoBehaviour
{
    public YandexGame sdk;
    public TextMeshProUGUI coinsText;
    public Coins _coinsMananger;

    public void Start() => _coinsMananger = GameObject.Find("CoinsMananger").GetComponent<Coins>();
    
    public void AdButton() => sdk._RewardedShow(1);

    public void AdButtonCul()
    {
        _coinsMananger.coins += 25;
        PlayerPrefs.SetInt("Coins", _coinsMananger.coins);
        coinsText.text = _coinsMananger.coins.ToString();
    }
}
