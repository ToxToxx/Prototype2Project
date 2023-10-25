using UnityEngine;

public abstract class HealthLogic : MonoBehaviour
{
    [SerializeField] public int MaxHealth;
    public int CurrentHealth;

    private void Start()
    {
        CurrentHealth = MaxHealth;
    }


    public virtual void TakeDamage(int damageAmount)
    {

        CurrentHealth -= damageAmount;

        if (CurrentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
