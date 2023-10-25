using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emerald : MonoBehaviour
{
    [SerializeField] private Coins _coinsMananger;
    [SerializeField] private float _speed;
    private GameController _score;

    private void Start()
    {
        _coinsMananger = GameObject.Find("CoinsMananger").GetComponent<Coins>();
        _score = GameObject.Find("Chicken").GetComponent<GameController>();
        
        if (_score.score >= 100)
            _speed *= _score.score / 100;
    }

    private void Update() => transform.position = Vector2.MoveTowards(transform.position, transform.position - transform.right, _speed * Time.deltaTime);

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Chicken")
        {
            _coinsMananger.coins++;
            PlayerPrefs.SetInt("Coins", _coinsMananger.coins);
            Destroy(gameObject); 
        }
        
        if(col.gameObject.CompareTag("killZone"))
            Destroy(gameObject);
    }
}
