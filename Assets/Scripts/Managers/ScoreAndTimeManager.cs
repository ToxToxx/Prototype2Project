using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAndTimeManager : MonoBehaviour
{
    public static ScoreAndTimeManager Instance;
    [SerializeField] private int score;
    [SerializeField] private int maxScore;
    [SerializeField] private int bestScore;
    [SerializeField] private float maxTime;
    private float currentTime;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        score = 0;
        currentTime = 0;
        bestScore = PlayerPrefs.GetInt("BestScore", 0);

    }

    void Update()
    {
        currentTime += Time.deltaTime;
        SetBestScore();
    }


    public void SetScore(int scoreAmount)
    {
        score += scoreAmount;
    }

    public int GetScore()
    {
        return score;
    }

    public void SetMaxScore(int maxScoreAmount)
    {
        maxScore = maxScoreAmount;
    }
    public int GetMaxScore()
    {
        return maxScore;
    }

    public void SetBestScore()
    {
        if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt("BestScore", bestScore);
        }
    }

    public int GetBestScore()
    {
        return bestScore;
    }


    public float GetCurrentTime()
    {
        return currentTime;
    }


    public void SetMaxTime(float maxTimeAmount)
    {
        maxTime = maxTimeAmount;
    }
    public float GetMaxTime()
    {
        return maxTime;
    }
}
