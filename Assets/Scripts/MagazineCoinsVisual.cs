using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MagazineCoinsVisual : MonoBehaviour
{
    public Coins coinsMananger;
    public TextMeshProUGUI coinsText;

    void Start() => coinsMananger = GameObject.Find("CoinsMananger").GetComponent<Coins>();

    void Update() => coinsText.text = coinsMananger.coins.ToString();
}
