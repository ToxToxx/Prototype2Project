using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public static class ShowResultsCommand
{
    public static void ShowResults(TextMeshProUGUI scoreText, TextMeshProUGUI timeText)
    {
        scoreText.text = "счет: " + ScoreAndTimeManager.Instance.GetScore();

        string formattedTime = ScoreAndTimeManager.Instance.GetCurrentTime().ToString("0.00");
        timeText.text = "время: " + formattedTime;
    }
}
