using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _enemySpeed = 3;
    private Transform _enemyTransform;

    private void Start()
    {
       _enemyTransform = transform;
    }

    void Update()
    {
        _enemyTransform.Translate(_enemySpeed * Time.deltaTime * Vector3.back);
    }


}
