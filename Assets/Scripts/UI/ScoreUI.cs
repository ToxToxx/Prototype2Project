using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public static ScoreUI Instance;

    [SerializeField] private TextMeshProUGUI _scoreText;

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (GameManager.Instance.GetScoreSwitcher())
        {
            _scoreText.color = Color.red;
            _scoreText.text = "счет: " + ScoreAndTimeManager.Instance.GetScore() + " / " + ScoreAndTimeManager.Instance.GetMaxScore();
        }
        else
        {
            _scoreText.color = Color.yellow;
            _scoreText.text = "счет: " + ScoreAndTimeManager.Instance.GetScore();
        }
        
    }
}
