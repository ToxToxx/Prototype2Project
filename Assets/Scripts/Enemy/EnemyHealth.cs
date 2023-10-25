using UnityEngine;

public sealed class EnemyHealth : HealthLogic
{
    [SerializeField] private int _armor = 5;
    [SerializeField] private int _scoreDeath = 5;

    public override void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount - _armor;

        if (currentHealth <= 0)
        {
            Die();
            ScoreAndTimeManager.Instance.SetScore(_scoreDeath);
        }
    }
    private void OnDestroy()
    {
        EnemySpawner.Instance.DecreaseCurrentEnemy();
    }

}
