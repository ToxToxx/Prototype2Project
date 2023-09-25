using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthPotionsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthPotionsText;

    void Update()
    {
        healthPotionsText.text = "€чейки лечени€: " + Convert.ToString(PlayerHealth.Instance.GetPotionsCount());
    }
}
