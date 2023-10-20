using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject obj;
    public float Delay = 5f;
    private Vector2 Pos;
    private float randPosY;

    void Start()
    {
        StartCoroutine(spawns());
    }

    IEnumerator spawns()
    {
        while (true)
        {
            yield return new WaitForSeconds(Delay);
            randPosY = Random.Range(-2.71f, 1.13f);
            Pos = new Vector3(7, randPosY, 0);
            Instantiate(obj, Pos, Quaternion.identity);
            Debug.Log("- заспавнился"+ randPosY);
        }
    }
}