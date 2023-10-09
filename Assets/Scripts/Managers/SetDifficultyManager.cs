using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDifficultyManager : MonoBehaviour
{
    public static SetDifficultyManager Instance;

    [SerializeField] public int easyMaxScore;
    [SerializeField] public int mediumMaxScore;
    [SerializeField] public int hardMaxScore;

    [SerializeField] public float easyMaxTime;
    [SerializeField] public float mediumMaxTime;
    [SerializeField] public float hardMaxTime;

    [SerializeField] public float easySpawnerTime;
    [SerializeField] public float mediumSpawnerTime;
    [SerializeField] public float hardSpawnerTime;

    [SerializeField] public float easyScoreCoef;
    [SerializeField] public float mediumScoreCoef;
    [SerializeField] public float hardScoreCoef;

    private void Awake()
    {
        Instance = this;
    }
}
