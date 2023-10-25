using UnityEngine;
using UnityEngine.UI;

public class TutorialUI : MonoBehaviour, IUserInterfaceWindow
{
    [SerializeField] private GameObject _mainMenuUI;
    [SerializeField] private Button _tutorialHideButton;

    private void Awake()
    {      
        _tutorialHideButton.onClick.AddListener(() =>
        {
            Hide();
            _mainMenuUI.GetComponent<MainMenuUI>().Show();
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
