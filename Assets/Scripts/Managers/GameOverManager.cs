using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public static GameOverManager Instance;
    [SerializeField] private GameOverUI gameOverUI;
    [SerializeField] private GameWonUI gameWonUI;
    public event EventHandler GameIsOver;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        gameOverUI.Hide();
        gameWonUI.Hide();
    }

    void Update()
    {
        if (!Player.Instance.IsDestroyed())
        {
            if (GameManager.Instance.GetScoreSwitcher() && !GameManager.Instance.GetTimeSwitcher())
            {
                GameOnScoreOver();
            }
            else if (GameManager.Instance.GetTimeSwitcher() && !GameManager.Instance.GetScoreSwitcher())
            {
                GameOnTimeOver();
            }
        } 
        else
        {
            GameOver();
           
        }
        
    }

    private void GameOnScoreOver()
    {
        if(ScoreAndTimeManager.Instance.GetScore() >= ScoreAndTimeManager.Instance.GetMaxScore())
        {
            gameWonUI.Show();
            Time.timeScale = 0;
            GameIsOver?.Invoke(this, EventArgs.Empty);
        }
    }
    private void GameOnTimeOver()
    {
        if (ScoreAndTimeManager.Instance.GetCurrentTime() >= ScoreAndTimeManager.Instance.GetMaxTime())
        {
            gameWonUI.Show();
            Time.timeScale = 0;
            GameIsOver?.Invoke(this, EventArgs.Empty);
        }
    }
    private void GameOver()
    {
        gameOverUI.Show();
        Time.timeScale = 0;
        GameIsOver?.Invoke(this, EventArgs.Empty);
    }
}
