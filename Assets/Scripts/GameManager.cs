using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;
    public int totalCoins;
    public float timeLeft;
    public int timeRemaining;

    public float timerValue;
    [Header("UI")]
    public Text txt_score;
    public Text txt_timer;
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
        timeLeft -= Time.deltaTime;
        timeRemaining = Mathf.FloorToInt(timeLeft % 60);

        txt_timer.text = "Timer : " + timeRemaining.ToString();


        if(score >= totalCoins)
        {
            if(timeLeft <= timerValue)
            {
                SceneManager.LoadScene("GameWinScene");
            }
        }
        else if (timeLeft <= 0)
        {
            SceneManager.LoadScene("GameLoseScene");
        }
    }

    public void IncreaseScoreBy(int score)
    {
        this.score += score;
        txt_score.text = "SCORE: " + this.score.ToString("N0");
    }
}
