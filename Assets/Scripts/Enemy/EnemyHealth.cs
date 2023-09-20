using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyHealth : HealthLogic
{
    [SerializeField] private int armor;
    [SerializeField] private int scoreDeath;

    public override void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount - armor;

        if (currentHealth <= 0)
        {
            Die();
            ScoreUI.Instance.SetScore(scoreDeath);
        }
    }
    private void OnDestroy()
    {
        EnemySpawner.Instance.DecreaseCurrentEnemy();
    }

}
