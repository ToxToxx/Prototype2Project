using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public static ScoreUI Instance;

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private int score;
    [SerializeField] private int maxScore;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        score = 0;
    }
    void Update()
    {
        if (GameManager.Instance.GetScoreSwitcher())
        {
            scoreText.color = Color.red;
            scoreText.text = "Score: " + score + " / " + maxScore;
        }
        else
        {
            scoreText.color = Color.yellow;
            scoreText.text = "Score: " + score;
        }
        
    }

    public void SetScore(int scoreAmount)
    {
        score += scoreAmount;
    }



    public int GetScore()
    {
        return score;
    }

    public int GetMaxScore()
    {
        return maxScore;
    }
}
