public class SetGameType
{
    public enum GameType
    {
        Score,
        Time,
        Survival,
    }

    public static void SetScoreType()
    {
        GameManager.Instance.SetScoreSwitcher(true);
        GameManager.Instance.SetTimeSwitcher(false);
    }
    public static void SetTimeType()
    {
        GameManager.Instance.SetScoreSwitcher(false);
        GameManager.Instance.SetTimeSwitcher(true);
    }
    public static void SetSurvivalType()
    {
        GameManager.Instance.SetScoreSwitcher(false);
        GameManager.Instance.SetTimeSwitcher(false);
    }
}
