using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public int coins;

    void Start() => coins = PlayerPrefs.GetInt("Coins");
    
    public void Update()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}