using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float Speed = 1f;
    public Rigidbody2D rb;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() 
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.position - transform.right, Speed * Time.deltaTime);
        if(transform.position.x < -6)
        {
            Destroy(gameObject);
        }
    }
 } 