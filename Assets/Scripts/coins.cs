using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public float coins;

    public void Update() => DontDestroyOnLoad(this.gameObject);
}