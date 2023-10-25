using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MoveLeft : MonoBehaviour
{
    [FormerlySerializedAs("Speed")] public float speed = 1f;
    public Rigidbody2D rb;
    private GameController _score;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _score = GameObject.Find("Chicken").GetComponent<GameController>();
        
        if (_score.score >= 100)
            speed *= _score.score / 100;
    }

    private void Update() 
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.position - transform.right, speed * Time.deltaTime);

        if(transform.position.x <= -6)
            Destroy(gameObject);
    }
 } 