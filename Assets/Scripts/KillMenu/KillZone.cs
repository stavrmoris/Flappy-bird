using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public bool CollisionKillZone;
    public GameObject canvas;

    void Update()
    {
        if(CollisionKillZone)
        {
            canvas.SetActive(true);
        }
    }
}
