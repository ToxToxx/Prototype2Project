using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI gameOverScoreText;
    [SerializeField] private TextMeshProUGUI gameOverTimeText;

    void Update()
    {
        ShowResultsCommand.ShowResults(gameOverScoreText, gameOverTimeText);
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
