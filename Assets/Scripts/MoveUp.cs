using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float JumpForce;
    private Rigidbody2D rb;
    Transform tf;
    public float Spead;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tf = GetComponent<Transform>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce (new Vector2(transform.position.x, JumpForce));
        }

        tf.position = (new Vector2(transform.position.x * Spead, transform.position.y));
    }
}
