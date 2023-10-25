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
        ScoreAndTimeManager.Instance.SetMaxScore(SetDifficultyManager.Instance.EasyMaxScore);
        ScoreAndTimeManager.Instance.SetMaxTime(SetDifficultyManager.Instance.EasyMaxTime);
        DifficultyManager.Instance.SetTimeEnemySpawnerDecreaser(SetDifficultyManager.Instance.EasySpawnerTime);
        ScoreAndTimeManager.Instance.SetScoreCoef(SetDifficultyManager.Instance.EasyScoreCoef);
    }
    public static void SetMediumDifficulty()
    {
        ScoreAndTimeManager.Instance.SetMaxScore(SetDifficultyManager.Instance.MediumMaxScore);
        ScoreAndTimeManager.Instance.SetMaxTime(SetDifficultyManager.Instance.MediumMaxTime);
        DifficultyManager.Instance.SetTimeEnemySpawnerDecreaser(SetDifficultyManager.Instance.MediumSpawnerTime);
        ScoreAndTimeManager.Instance.SetScoreCoef(SetDifficultyManager.Instance.MediumScoreCoef);
    }
    public static void SetHardDifficulty()
    {
        ScoreAndTimeManager.Instance.SetMaxScore(SetDifficultyManager.Instance.HardMaxScore);
        ScoreAndTimeManager.Instance.SetMaxTime(SetDifficultyManager.Instance.HardMaxTime);
        DifficultyManager.Instance.SetTimeEnemySpawnerDecreaser(SetDifficultyManager.Instance.HardSpawnerTime);
        ScoreAndTimeManager.Instance.SetScoreCoef(SetDifficultyManager.Instance.HardScoreCoef);
    }
}
