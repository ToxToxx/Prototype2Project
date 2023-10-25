using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public static MainMenuUI Instance;

    [SerializeField] private GameObject _tutorialUI;
    [SerializeField] private GameObject _chooseGameTypeAndDifficultyUI;

    [SerializeField] private Button _playButton;
    [SerializeField] private Button _tutorialInfoButton;

    private void Awake()
    {
        _playButton.onClick.AddListener(() =>
        {
            HideMainMenu();
            _chooseGameTypeAndDifficultyUI.GetComponent<ChooseGameTypeAndDifficultyUI>().ShowChooseScreen();
        });
        _tutorialInfoButton.onClick.AddListener(() =>
        {
            HideMainMenu();
            _tutorialUI.GetComponent<TutorialUI>().ShowTutorial();
        });



        Time.timeScale = 1.0f;
    }

    public void ShowMainMenu()
    {
        gameObject.SetActive(true);
    }

    public void HideMainMenu()
    {
        gameObject.SetActive(false);
    }
}
