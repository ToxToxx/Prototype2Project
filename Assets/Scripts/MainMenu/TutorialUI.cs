using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialUI : MonoBehaviour, IUserInterfaceWindow
{
    [SerializeField] private GameObject mainMenuUI;
    [SerializeField] private Button tutorialHideButton;

    private void Awake()
    {      
        tutorialHideButton.onClick.AddListener(() =>
        {
            Hide();
            mainMenuUI.GetComponent<MainMenuUI>().Show();
        });
    }
    private void Start()
    {
        Hide();
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
