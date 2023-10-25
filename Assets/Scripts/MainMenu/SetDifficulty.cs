public class SetDifficulty
{
    public enum GameDifficulty
    {
        Easy,
        Medium,
        Hard,         
    }


    public static void SetEasyDifficulty()
    {
        ScoreAndTimeManager.Instance.SetMaxScore(SetDifficultyManager.Instance.easyMaxScore);
        ScoreAndTimeManager.Instance.SetMaxTime(SetDifficultyManager.Instance.easyMaxTime);
        DifficultyManager.Instance.SetTimeEnemySpawnerDecreaser(SetDifficultyManager.Instance.easySpawnerTime);
        ScoreAndTimeManager.Instance.SetScoreCoef(SetDifficultyManager.Instance.easyScoreCoef);
    }
    public static void SetMediumDifficulty()
    {
        ScoreAndTimeManager.Instance.SetMaxScore(SetDifficultyManager.Instance.mediumMaxScore);
        ScoreAndTimeManager.Instance.SetMaxTime(SetDifficultyManager.Instance.mediumMaxTime);
        DifficultyManager.Instance.SetTimeEnemySpawnerDecreaser(SetDifficultyManager.Instance.mediumSpawnerTime);
        ScoreAndTimeManager.Instance.SetScoreCoef(SetDifficultyManager.Instance.mediumScoreCoef);
    }
    public static void SetHardDifficulty()
    {
        ScoreAndTimeManager.Instance.SetMaxScore(SetDifficultyManager.Instance.hardMaxScore);
        ScoreAndTimeManager.Instance.SetMaxTime(SetDifficultyManager.Instance.hardMaxTime);
        DifficultyManager.Instance.SetTimeEnemySpawnerDecreaser(SetDifficultyManager.Instance.hardSpawnerTime);
        ScoreAndTimeManager.Instance.SetScoreCoef(SetDifficultyManager.Instance.hardScoreCoef);
    }
}
