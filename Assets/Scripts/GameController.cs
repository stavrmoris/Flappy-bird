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
    [FormerlySerializedAs("ScoreText")] public TextMeshProUGUI scoreText2;
    [FormerlySerializedAs("coinsText")] public TextMeshProUGUI coinsText;

    [FormerlySerializedAs("Score")] public float score = 0;
    [FormerlySerializedAs("RecordScore")] public float recordScore = 0;

    private Transform _obj;
    public Coins coinsMananger;

    [FormerlySerializedAs("Kill zone")] public KillZone kz;

    void Start()
    {
        _obj = GetComponent<Transform>();
        recordScore = PlayerPrefs.GetInt("RREcordScore");
        coinsMananger = GameObject.Find("CoinsMananger").GetComponent<Coins>();
        kz = GameObject.Find("Main Camera").GetComponent<KillZone>();
    }
    
    void FixedUpdate()
    {
        recordScore = PlayerPrefs.GetFloat("RecordScore");
        
        scoreText.text = score.ToString(CultureInfo.InvariantCulture);
        if(!kz.CollisionKillZone)
            scoreText2.text = score.ToString(CultureInfo.InvariantCulture);
        recordScoreText.text = recordScore.ToString(CultureInfo.InvariantCulture);
        coinsText.text = coinsMananger.coins.ToString(CultureInfo.InvariantCulture);

        if (recordScore < score)
        {
        PlayerPrefs.SetFloat("RecordScore", score);
        }
    }

    void Update()
    {
        if(_obj.position.y > 2.79)
        {   Debug.Log("Я УЛЕТЕЛА");
            kz.CollisionKillZone = true;
            Destroy(gameObject);
            
        }
    }
        

    

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("killZone"))
        {
            kz.CollisionKillZone = true;
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
