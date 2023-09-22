using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private GameOverUI gameOverUI;
    [SerializeField] private GameWonUI gameWonUI;

    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.GameOverHide();
        gameWonUI.GameWonHide();
    }

    // Update is called once per frame
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
            gameWonUI.GameWonShow();
            Time.timeScale = 0;
        }
    }
    private void GameOnTimeOver()
    {
        if (ScoreAndTimeManager.Instance.GetCurrentTime() >= ScoreAndTimeManager.Instance.GetMaxTime())
        {
            gameWonUI.GameWonShow();
            Time.timeScale = 0;
        }
    }
    private void GameOver()
    {
        gameOverUI.GameOverShow();
        Time.timeScale = 0;
    }
}
