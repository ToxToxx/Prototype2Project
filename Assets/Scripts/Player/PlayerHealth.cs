using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : HealthLogic
{
    public static PlayerHealth Instance { get; set; }
    [SerializeField] private int healAmount;
    [SerializeField] private int healCount;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        currentHealth = maxHealth;
        GameInput.Instance.OnHeal += GameInput_OnHeal;
    }



    private void GameInput_OnHeal(object sender, System.EventArgs e)
    {
        Heal();
    }

    private void Heal()
    {
        if(healCount > 0 && currentHealth < maxHealth)
        {
            currentHealth += healAmount;
            if(currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
            healCount--;
        } else
        {
            Debug.Log("You can't heal");
        }
        
    }

    public int GetPotionsCount()
    {
        return healCount;
    }


}
