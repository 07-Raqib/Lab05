using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;

    [Header("UI")]
    public Text txt_score;
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScoreBy(int score)
    {
        this.score += score;
        txt_score.text = "SCORE: " + this.score.ToString("N0");
    }
}
