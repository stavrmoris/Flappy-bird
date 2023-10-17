using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skins : MonoBehaviour
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
                skin[i].SetActive(true);
            }
        }
    }
}
