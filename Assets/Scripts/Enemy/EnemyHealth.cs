using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : HealthLogic
{

    [SerializeField] private int armor;

    public override void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount - armor;

        if (currentHealth <= 0)
        {
            Die();
        }
    }




}
