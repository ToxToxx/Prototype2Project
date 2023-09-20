using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthPointsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthPointsText;

    void Update()
    {
        healthPointsText.text = "Health Points: " + PlayerHealth.Instance.currentHealth;
    }
}
