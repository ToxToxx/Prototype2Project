using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour, IUserInterfaceWindow
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
            Hide();
            _chooseGameTypeAndDifficultyUI.GetComponent<ChooseGameTypeAndDifficultyUI>().Show();
        });
        _tutorialInfoButton.onClick.AddListener(() =>
        {
            Hide();
            _tutorialUI.GetComponent<TutorialUI>().Show();
        });



        Time.timeScale = 1.0f;
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
