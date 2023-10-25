using TMPro;
using UnityEngine;

public class HealthPointsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _healthPointsText;

    void Update()
    {
        _healthPointsText.text = "��������: " + PlayerHealth.Instance.CurrentHealth;
    }
}
