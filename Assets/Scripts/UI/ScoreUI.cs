using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public static ScoreUI Instance;

    [SerializeField] private TextMeshProUGUI scoreText;

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (GameManager.Instance.GetScoreSwitcher())
        {
            scoreText.color = Color.red;
            scoreText.text = "счет: " + ScoreAndTimeManager.Instance.GetScore() + " / " + ScoreAndTimeManager.Instance.GetMaxScore();
        }
        else
        {
            scoreText.color = Color.yellow;
            scoreText.text = "счет: " + ScoreAndTimeManager.Instance.GetScore();
        }
        
    }
}
