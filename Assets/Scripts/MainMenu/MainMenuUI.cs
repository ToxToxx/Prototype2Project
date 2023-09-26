using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public static MainMenuUI Instance;

    [SerializeField] private GameObject tutorialUI;
    [SerializeField] private GameObject chooseGameTypeAndDifficultyUI;

    [SerializeField] private Button playButton;
    [SerializeField] private Button tutorialButton;
    [SerializeField] private Button quitButton;

    private void Awake()
    {
        playButton.onClick.AddListener(() =>
        {
            HideMainMenu();
            chooseGameTypeAndDifficultyUI.GetComponent<ChooseGameTypeAndDifficultyUI>().ShowChooseScreen();
        });
        tutorialButton.onClick.AddListener(() =>
        {
            HideMainMenu();
            tutorialUI.GetComponent<TutorialUI>().ShowTutorial();
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
