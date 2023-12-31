using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magazine : MonoBehaviour
{
    [SerializeField] public GameObject[] skin;

    private void Start()
    {
        var count = PlayerPrefs.GetInt("ActiveSkin");
        
        for(int i = 0; i < skin.Length; i++)
        {
            if(i != count)
                skin[i].SetActive(false);
            else
            {
                PlayerPrefs.SetFloat("ActiveSkin", count);
                skin[i].SetActive(true);
            }
        }
    }

    public void GetSkin(int count)
    {
        for(int i = 0; i < skin.Length; i++)
        {
            if(i != count)
                skin[i].SetActive(false);
            else
            {
                PlayerPrefs.SetInt("ActiveSkin", count);
                skin[i].SetActive(true);
            }
        }
    }
}
