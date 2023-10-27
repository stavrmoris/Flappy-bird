using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MoveLeft : MonoBehaviour
{
    [FormerlySerializedAs("Speed")] public float speed = 1f;
    public Rigidbody2D rb;
    private GameController _score;
    private Spawn _Delay;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _score = GameObject.Find("Chicken").GetComponent<GameController>();
        _Delay = GameObject.Find("Chicken").GetComponent<Spawn>();
//           СВОБОДУ IF

    if (_score.score >= 30 )
    {
        speed += 0.2f;
        _Delay.Delay -= 0.2f;
        Debug.Log("Скорость увеличена");
    }

    if (_score.score >= 60 )
    {
        speed += 0.2f;
        _Delay.Delay -= 0.2f;
        Debug.Log("Скорость увеличена");
    }

    if (_score.score >= 90 )
    {
        speed += 0.2f;
        _Delay.Delay -= 0.2f;
        Debug.Log("Скорость увеличена");
    }

    if (_score.score >= 120 )
    {
        speed += 0.2f;
        _Delay.Delay -= 0.2f;
        Debug.Log("Скорость увеличена");
    }
    
    if (_score.score >= 150 )
    {
        speed += 0.2f;
        _Delay.Delay -= 0.2f;
        Debug.Log("Скорость увеличена");
    }

    if (_score.score >= 180 )
    {
        speed += 0.2f;
        _Delay.Delay -= 0.2f;
        Debug.Log("Скорость увеличена");
    }
    if (_score.score >= 210 )
    {
        speed += 0.2f;
        _Delay.Delay -= 0.2f;
        Debug.Log("Скорость увеличена");
    }

    if (_score.score >= 240 )
    {
        speed += 0.2f;
        _Delay.Delay -= 0.2f;
        Debug.Log("Скорость увеличена");
    }
    
    if (_score.score >= 270 )
    {
        speed += 0.2f;
        _Delay.Delay -= 0.2f;
        Debug.Log("Скорость увеличена");
    }

    if (_score.score >= 300 )
    {
        speed += 0.2f;
        _Delay.Delay -= 0.2f;
        Debug.Log("Скорость увеличена");
    }

    }

    private void Update() 
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.position - transform.right, speed * Time.deltaTime);

        if(transform.position.x <= -6)
            Destroy(gameObject);
    }
 } 