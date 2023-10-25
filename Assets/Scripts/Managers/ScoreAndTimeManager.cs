using UnityEngine;

public class ScoreAndTimeManager : MonoBehaviour
{
    public static ScoreAndTimeManager Instance;

    [SerializeField] private float _score;
    [SerializeField] private float _maxScore;
    [SerializeField] private float _bestScore;
    [SerializeField] private float _maxTime;

    private float _currentTime;
    private float _scoreCoef;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        _score = 0;
        _currentTime = 0;
        _bestScore = PlayerPrefs.GetInt("BestScore", 0);

    }

    void Update()
    {
        _currentTime += Time.deltaTime;
        SetBestScore();
    }


    public void SetScore(float scoreAmount)
    {
        _score += scoreAmount * _scoreCoef;
    }
    public void SetScoreCoef(float scoreCoefAmount)
    {
        _scoreCoef = scoreCoefAmount;
    }
    public float GetScore()
    {
        return _score;
    }

    public void SetMaxScore(int maxScoreAmount)
    {
        _maxScore = maxScoreAmount;
    }
    public float GetMaxScore()
    {
        return _maxScore;
    }

    public void SetBestScore()
    {
        if (_score > _bestScore)
        {
            _bestScore = _score;
            PlayerPrefs.SetFloat("BestScore", _bestScore);
        }
    }

    public float GetBestScore()
    {
        return _bestScore;
    }


    public float GetCurrentTime()
    {
        return _currentTime;
    }


    public void SetMaxTime(float maxTimeAmount)
    {
        _maxTime = maxTimeAmount;
    }
    public float GetMaxTime()
    {
        return _maxTime;
    }
}
