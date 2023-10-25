using TMPro;
using UnityEngine;

public class HealthPointsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthPointsText;

    void Update()
    {
        healthPointsText.text = "здоровье: " + PlayerHealth.Instance.currentHealth;
    }
}
