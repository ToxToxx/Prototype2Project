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
    [SerializeField] private bool scoreSwitch;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        scoreSwitch = false;
        score = 0;
    }
    void Update()
    {
        if (scoreSwitch)
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

    public void SetScoreType(bool scoreType)
    {
        scoreSwitch = scoreType;
    }
}
