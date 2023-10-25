using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public static DifficultyManager Instance;


    [SerializeField] private float _timeEnemySpawnerDecreaser;
    [SerializeField] private float _scoreTreshold;
    [SerializeField] private bool _isDifficultyChanged;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        _isDifficultyChanged = false;
    }
    void Update()
    {
        ScoreDifficultySet();     
    }

    private void ScoreDifficultySet()
    {
        float currentScore = ScoreAndTimeManager.Instance.GetScore();
        if (currentScore % _scoreTreshold == 0 && currentScore > 0 && !_isDifficultyChanged && EnemySpawner.Instance.GetMaxTimer() > 1)
        {
            EnemySpawner.Instance.DecreaseMaxTimer(_timeEnemySpawnerDecreaser);
            _isDifficultyChanged = true;
        }
        else if (currentScore % _scoreTreshold != 0)
        {
            _isDifficultyChanged = false;
        }
    }

    public void SetTimeEnemySpawnerDecreaser(float timeAmount)
    {
        _timeEnemySpawnerDecreaser = timeAmount;
    }
}
