using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAndTimeManager : MonoBehaviour
{
    public static ScoreAndTimeManager Instance;
    [SerializeField] private float score;
    [SerializeField] private float maxScore;
    [SerializeField] private float bestScore;
    [SerializeField] private float maxTime;
    private float currentTime;
    private float scoreCoef;

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


    public void SetScore(float scoreAmount)
    {
        score += scoreAmount / scoreCoef;
    }
    public void SetScoreCoef(float scoreCoefAmount)
    {
        scoreCoef = scoreCoefAmount;
    }
    public float GetScore()
    {
        return score;
    }

    public void SetMaxScore(int maxScoreAmount)
    {
        maxScore = maxScoreAmount;
    }
    public float GetMaxScore()
    {
        return maxScore;
    }

    public void SetBestScore()
    {
        if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetFloat("BestScore", bestScore);
        }
    }

    public float GetBestScore()
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
