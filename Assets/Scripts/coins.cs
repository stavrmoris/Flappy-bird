using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    private GameController gcr;
    void Start()
    {
        gcr = GameObject.Find("Chicken").GetComponent<GameController>();
    }
        
    
    void OnTriggerEnter2D(Collider2D Other)
    {
        if(Other.gameObject.tag == "Player")
        {
            gcr.Score +=100;
            Destroy(gameObject);
            Debug.Log("GOTOVO");
        }
    }
}
