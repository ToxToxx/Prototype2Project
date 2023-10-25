using TMPro;
using UnityEngine;

public class TimeUI : MonoBehaviour
{
    public static TimeUI Instance;

    [SerializeField] private TextMeshProUGUI _timeText;

    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        string formattedTime = ScoreAndTimeManager.Instance.GetCurrentTime().ToString("0.00");
        if (GameManager.Instance.GetTimeSwitcher())
        {
            _timeText.color = Color.red;
            _timeText.text = "время: " + formattedTime + " / " + ScoreAndTimeManager.Instance.GetMaxTime();
        }
        else
        {
            _timeText.color = Color.yellow;
            _timeText.text = "время: " + formattedTime;
        }

    }
}

