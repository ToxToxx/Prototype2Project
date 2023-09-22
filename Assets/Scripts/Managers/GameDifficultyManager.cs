using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SetDifficulty;

public class GameDifficultyManager : MonoBehaviour
{
    public static GameDifficultyManager Instance;

    [SerializeField] private bool timeSwitcher;
    [SerializeField] private bool scoreSwitcher;
    public GameDifficulty currentDifficulty = GameDifficulty.Medium;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {

    }

    void Update()
    {
        switch (currentDifficulty)
        {
            case GameDifficulty.Easy:
                SetEasyDifficulty();
                break; 
            case GameDifficulty.Medium:
                SetMediumDifficulty();
                break; 
            case GameDifficulty.Hard:
                SetHardDifficulty();
                break;
        }

    }
}
