using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private int _damageAmount = 3;

    public int GetDamage()
    {
        return _damageAmount;
    }
}
