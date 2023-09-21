using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI gameOverScoreText;
    [SerializeField] private TextMeshProUGUI gameOverTimeText;

    void Update()
    {
        gameOverScoreText.text = "Score: " + ScoreUI.Instance.GetScore();

        string formattedTime = TimeUI.Instance.GetCurrentTime().ToString("0.00");
        gameOverTimeText.text = "Time: " + formattedTime;
    }

    public void GameOverShow()
    {
        gameObject.SetActive(true);
    }
    public void GameOverHide()
    {
        gameObject.SetActive(false);
    }
}
