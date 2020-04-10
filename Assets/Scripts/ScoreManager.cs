using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;
    public Text HighScoreText;
    public GameObject Sphere;
    private Rigidbody rigid;
    private float Speed;
    private float TimeDeltaTime;
    private float Product;
    public int Coefficient; //100以上の値を設定する。
    private int Score;
    private int HighScore;
    private string HighScoreKey = "HighScore";

    void Start(){
        Initialize();
        rigid = Sphere.GetComponent<Rigidbody>();
    }

    void Update(){
        if(HighScore < Score){
            HighScore = Score;
        }
        TimeDeltaTime = Time.deltaTime;
        Speed = rigid.velocity.magnitude;
        Product = Speed * Speed * TimeDeltaTime * Coefficient;
        Score = Score + (int)Product;
        ScoreText.text = Score.ToString();
        HighScoreText.text = HighScore.ToString();
    }

    private void Initialize(){
        Score = 0;
        HighScore = PlayerPrefs.GetInt(HighScoreKey, 0);
    }

    public void Save(){
        PlayerPrefs.SetInt(HighScoreKey, HighScore);
        PlayerPrefs.Save();
        Initialize();
    }
}
