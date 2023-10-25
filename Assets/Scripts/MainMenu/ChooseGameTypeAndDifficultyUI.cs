using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static SetDifficulty;
using static SetGameType;

public class ChooseGameTypeAndDifficultyUI : MonoBehaviour, ChangeDifficultyInterface
{
    public static ChooseGameTypeAndDifficultyUI Instance;

    [SerializeField] private MainMenuUI _mainMenuUI;

    [SerializeField] private TextMeshProUGUI _difficultyText;
    [SerializeField] private TextMeshProUGUI _gameTypeText;

    [SerializeField] private Button _difficultyHideButton;
    [SerializeField] private Button _setGameTypeButton;
    [SerializeField] private Button _setDifficultyButton;
    [SerializeField] private Button _playButton;

    private GameDifficulty _gameDifficulty;
    private GameType _gameType;
    private string _localizationDifficultyName = " ";

    private void Awake()
    {
        Instance = this;

        _difficultyHideButton.onClick.AddListener(() =>
        {
            HideChooseScreen();
            _mainMenuUI.GetComponent<MainMenuUI>().ShowMainMenu();
        });
        _setGameTypeButton.onClick.AddListener(() =>
        {
            ChangeGameType();
        });
        _setDifficultyButton.onClick.AddListener(() =>
        {
            ChangeDifficulty();
           
        });
        _playButton.onClick.AddListener(() =>
        {
            Loader.Load(Loader.Scene.GameScene);
        });
    }
    private void Start()
    {
        HideChooseScreen();
    }

    public void ShowChooseScreen()
    {
        gameObject.SetActive(true);
    }

    public void HideChooseScreen()
    {
        gameObject.SetActive(false);
    }

    public void ChangeDifficulty()
    {
        _localizationDifficultyName = " ";
        switch (_gameDifficulty)
        {
            case GameDifficulty.Easy:
                _gameDifficulty = GameDifficulty.Medium;
                _localizationDifficultyName = "�������";
                break;
            case GameDifficulty.Medium:
                _gameDifficulty = GameDifficulty.Hard;
                _localizationDifficultyName = "�������";
                break;
            case GameDifficulty.Hard:
                _gameDifficulty = GameDifficulty.Easy;
                _localizationDifficultyName = "������";
                break;
            default:
                break;
        }
        _difficultyText.text = "���������: " + _localizationDifficultyName;
    }

    public void ChangeGameType()
    {
        string localizationTypeName = " ";
        switch (_gameType)
        {
            case GameType.Score:
                _gameType = GameType.Time;
                localizationTypeName = "�����";
                break;
            case GameType.Time:
                _gameType = GameType.Survival;
                localizationTypeName = "����";
                break;
            case GameType.Survival:
                _gameType = GameType.Score;
                localizationTypeName = "����";
                break;
            default:
                break;
        }
        _gameTypeText.text = "�����: " + localizationTypeName;
    }


    public GameType GetGameType()
    {
        return _gameType;
    }
    public GameDifficulty GetGameDifficulty()
    {
        return _gameDifficulty;

    }
}
