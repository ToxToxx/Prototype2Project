using TMPro;


public static class ShowResultsCommand
{
    public static void ShowResults(TextMeshProUGUI scoreText, TextMeshProUGUI timeText, TextMeshProUGUI bestScoreText)
    {
        scoreText.text = "счет: " + ScoreAndTimeManager.Instance.GetScore();

        string formattedTime = ScoreAndTimeManager.Instance.GetCurrentTime().ToString("0.00");
        timeText.text = "время: " + formattedTime;

        ScoreAndTimeManager.Instance.SetBestScore();
        bestScoreText.text = "лучший результат: " + ScoreAndTimeManager.Instance.GetBestScore();
    }
}
