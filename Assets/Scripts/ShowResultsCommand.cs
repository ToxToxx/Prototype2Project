using TMPro;


public static class ShowResultsCommand
{
    public static void ShowResults(TextMeshProUGUI scoreText, TextMeshProUGUI timeText, TextMeshProUGUI bestScoreText)
    {
        scoreText.text = "����: " + ScoreAndTimeManager.Instance.GetScore();

        string formattedTime = ScoreAndTimeManager.Instance.GetCurrentTime().ToString("0.00");
        timeText.text = "�����: " + formattedTime;

        ScoreAndTimeManager.Instance.SetBestScore();
        bestScoreText.text = "������ ���������: " + ScoreAndTimeManager.Instance.GetBestScore();
    }
}
