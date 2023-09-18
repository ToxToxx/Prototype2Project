using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : HealthLogic
{
    [SerializeField] private int healAmount;
    [SerializeField] private int healCount;
    

    private void Heal()
    {
        if(healCount > 0)
        {
            currentHealth += healAmount;
            healCount--;
        } else
        {
            Debug.Log("You can't heal");
        }
        
    }


}
