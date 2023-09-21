using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameWonUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI gameWonScoreText;
    [SerializeField] private TextMeshProUGUI gameWonTimeText;

    void Update()
    {
        gameWonScoreText.text = "Score: " + ScoreUI.Instance.GetScore();

        string formattedTime = TimeUI.Instance.GetCurrentTime().ToString("0.00");
        gameWonTimeText.text = "Time: " + formattedTime;
    }
    public void GameWonShow()
    {
        gameObject.SetActive(true);
    }
    public void GameWonHide()
    {
        gameObject.SetActive(false);
    }
}
