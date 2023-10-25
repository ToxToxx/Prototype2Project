using UnityEngine;

public class HitEnemy : MonoBehaviour
{
    [SerializeField] private int _damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<EnemyHealth>())
        {
            other.GetComponent<EnemyHealth>().TakeDamage(_damage);
            Destroy(gameObject);
        }
        
    }
}
