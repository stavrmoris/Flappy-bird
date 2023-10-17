using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Serialization;

public class GameController : MonoBehaviour
{
    [FormerlySerializedAs("ScoreText")] public TextMeshProUGUI scoreText;
    [FormerlySerializedAs("RecordScoreText")] public TextMeshProUGUI recordScoreText;
    [FormerlySerializedAs("coinsText")] public TextMeshProUGUI coinsText;

    [FormerlySerializedAs("Score")] public float score = 0;
    [FormerlySerializedAs("RecordScore")] public float recordScore = 0;

    private Transform _obj;
    public Coins coinsMananger;

    void Start()
    {
        _obj = GetComponent<Transform>();
        recordScore = PlayerPrefs.GetInt("RREcordScore");
        coinsMananger = GameObject.Find("CoinsMananger").GetComponent<Coins>();
    }
    
    void FixedUpdate()
    {
        recordScore = PlayerPrefs.GetFloat("RecordScore");
        
        scoreText.text = score.ToString(CultureInfo.InvariantCulture);
        recordScoreText.text = recordScore.ToString(CultureInfo.InvariantCulture);
        coinsText.text = coinsMananger.coins.ToString(CultureInfo.InvariantCulture);
        
        if(_obj.position.y > 5.04)
        {
            Destroy(gameObject);
        }
        
        if (recordScore < score)
        {
            PlayerPrefs.SetFloat("RecordScore", score);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("killZone"))
        {
           Destroy(gameObject); 
        }
    }
    
    void Awake()
    {
        StartCoroutine(Bonus());
    }

    IEnumerator Bonus()
    {

        do
        {
            yield return new WaitForSeconds(1f);
            score += 1;
        } while (true);
    }
}