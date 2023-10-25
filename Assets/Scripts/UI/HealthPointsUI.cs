using TMPro;
using UnityEngine;

public class HealthPointsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthPointsText;

    void Update()
    {
        healthPointsText.text = "��������: " + PlayerHealth.Instance.currentHealth;
    }
}
