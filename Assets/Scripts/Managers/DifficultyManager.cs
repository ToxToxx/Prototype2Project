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
        isDifficultyChanged = false;
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
        float currentScore = ScoreUI.Instance.GetScore();
        if (currentScore % scoreTreshold == 0 && currentScore > 0 && !isDifficultyChanged)
        {
            EnemySpawner.Instance.DecreaseMaxTimer(timeEnemySpawnerDecreaser);
            isDifficultyChanged = true;
        }
        else if (currentScore % scoreTreshold != 0)
        {
            isDifficultyChanged = false;
        }
    }

    private void TimeDifficultySet()
    {
        float currentTime = TimeUI.Instance.GetCurrentTime();
        if (currentTime % timeTreshold == 0 && currentTime > 0 && !isDifficultyChanged)
        {
            EnemySpawner.Instance.DecreaseMaxTimer(timeEnemySpawnerDecreaser);
            isDifficultyChanged = true;
        }
        else if (currentTime % timeTreshold != 0)
        {
            isDifficultyChanged = false;
        }
    }


}
