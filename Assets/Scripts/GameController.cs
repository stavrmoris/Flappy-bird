using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI RecordScoreText;

    public int Score = 0;
    public int RecordScore;

    private Transform obj;

    void Start()
    {
        obj = GetComponent<Transform>();
        RecordScore = PlayerPrefs.GetInt("RREcordScore");

    }


    void FixedUpdate()
    {
        ScoreText.text = Score.ToString();
        RecordScoreText.text = RecordScore.ToString();
        if(obj.position.y > 5.04)
        {
            Destroy(gameObject);
        }
        if (RecordScore < Score )
        {
            PlayerPrefs.SetInt("RREcordScore", Score);
        }
    }

    void OnCollisionEnter2D(Collision2D Col)
    {
        if(Col.gameObject.tag == "XYI")
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
        while(true)
        {
        

        yield return new WaitForSeconds(5);
        Score += 5; }
    }
}
