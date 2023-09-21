using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public static class ShowResultsCommand
{
    public static void ShowResults(TextMeshProUGUI scoreText, TextMeshProUGUI timeText)
    {
        scoreText.text = "Score: " + ScoreUI.Instance.GetScore();

        string formattedTime = TimeUI.Instance.GetCurrentTime().ToString("0.00");
        timeText.text = "Time: " + formattedTime;
    }
}
