using System;
using TMPro;
using UnityEngine;

public class HealthPotionsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _healthPotionsText;

    void Update()
    {
        _healthPotionsText.text = "������ �������: " + Convert.ToString(PlayerHealth.Instance.GetPotionsCount());
    }
}
