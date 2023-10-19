using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float JumpForce;
    private Rigidbody2D rb;
    public float Spead;
    public Animator anim;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    
    void OnMouseDown()

    {
        rb.AddForce(Vector2.up * (JumpForce - rb.velocity.y), ForceMode2D.Impulse);
        anim.SetTrigger("Fly");
    }
    
    void Update()
    {
        foreach (Touch touch in Input.touches) {

            if (touch.fingerId == 0) {
                if (Input.GetTouch(0).phase == TouchPhase.Began) {
                    rb.AddForce(Vector2.up * (JumpForce - rb.velocity.y), ForceMode2D.Impulse);
                    anim.SetTrigger("Fly");
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * (JumpForce - rb.velocity.y), ForceMode2D.Impulse);
            anim.SetTrigger("Fly");
        }

        rb.MoveRotation(rb.velocity.y * Spead);
    }
}
