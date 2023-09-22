using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public static DifficultyManager Instance;


    [SerializeField] private float timeEnemySpawnerDecreaser;
    [SerializeField] private float scoreTreshold;
    [SerializeField] private bool isDifficultyChanged;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        isDifficultyChanged = false;
    }
    void Update()
    {
        ScoreDifficultySet();     
    }

    private void ScoreDifficultySet()
    {
        float currentScore = ScoreAndTimeManager.Instance.GetScore();
        if (currentScore % scoreTreshold == 0 && currentScore > 0 && !isDifficultyChanged && EnemySpawner.Instance.GetMaxTimer() > 1)
        {
            EnemySpawner.Instance.DecreaseMaxTimer(timeEnemySpawnerDecreaser);
            isDifficultyChanged = true;
        }
        else if (currentScore % scoreTreshold != 0)
        {
            isDifficultyChanged = false;
        }
    }

    public void SetTimeEnemySpawnerDecreaser(float timeAmount)
    {
        timeEnemySpawnerDecreaser = timeAmount;
    }
}
