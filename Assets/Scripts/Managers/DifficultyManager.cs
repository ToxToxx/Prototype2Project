using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    [SerializeField] private float timeEnemySpawnerDecreaser;
    [SerializeField] private float scoreTreshold;
    [SerializeField] private float timeTreshold;
    [SerializeField] private bool isDifficultyChanged;

    private void Start()
    {
        isDifficultyChanged = true;
    }
    void Update()
    {
        if (GameManager.Instance.GetScoreSwitcher() == true)
        {
            ScoreDifficultySet();
        } 
        if(GameManager.Instance.GetTimeSwitcher() == true)
        {
            TimeDifficultySet();
        }
        
    }

    private void ScoreDifficultySet()
    {
        if (IsScoreOverTreshold() && !isDifficultyChanged)
        {
            EnemySpawner.Instance.DecreaseMaxTimer(timeEnemySpawnerDecreaser);
            
        }
    }
    private void TimeDifficultySet()
    {
        if (IsTimeOverTreshold() && !isDifficultyChanged)
        {
            EnemySpawner.Instance.DecreaseMaxTimer(timeEnemySpawnerDecreaser);
        }
    }

    private bool IsNaturalNumber(float number)
    {
        if (number < 1.0)
        {
            return false;
        }

        double integer = Math.Truncate(number);
        if (number - integer > 0.0)
        {
            return false;
        }
        return true;
    }

    private bool IsScoreOverTreshold()
    {
        if (IsNaturalNumber(ScoreUI.Instance.GetScore() % scoreTreshold) && EnemySpawner.Instance.GetMaxTimer() > 1)
        {
            isDifficultyChanged = true;
            return true;
        }
        isDifficultyChanged = false;
        return false;
    } 
    private bool IsTimeOverTreshold()
    {
        if (IsNaturalNumber(Convert.ToInt32(TimeUI.Instance.GetCurrentTime()) % timeTreshold) && EnemySpawner.Instance.GetMaxTimer() > 1)
        {
            isDifficultyChanged = true;
            return true;
        }
        isDifficultyChanged = false;
        return false;
    }
}
