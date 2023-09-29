using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI gameOverScoreText;
    [SerializeField] private TextMeshProUGUI gameOverTimeText;
    [SerializeField] private TextMeshProUGUI gameOverBestScoreText;

    void Update()
    {
        ShowResultsCommand.ShowResults(gameOverScoreText, gameOverTimeText, gameOverBestScoreText);
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
