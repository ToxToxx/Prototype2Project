using UnityEngine;
using static SetGameType;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private GameType _gameType;
    private bool _timeSwitcher;
    private bool _scoreSwitcher;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        _gameType = ChooseGameTypeAndDifficultyUI.Instance.GetGameType();
    }

    void Update()
    {
        switch (_gameType)
        {
            case GameType.Score:
                SetScoreType();
                break;
            case GameType.Time:
                SetTimeType();
                break;
            case GameType.Survival:
                SetSurvivalType();
                break;
        }
    }

    public void SetTimeSwitcher(bool timeSwitch)
    {
        _timeSwitcher = timeSwitch;
    }
    public void SetScoreSwitcher(bool scoreSwitch)
    {
        _scoreSwitcher = scoreSwitch;
    }
    public bool GetTimeSwitcher()
    {
        return _timeSwitcher;
    }
    public bool GetScoreSwitcher()
    {
        return _scoreSwitcher;
    }
}
