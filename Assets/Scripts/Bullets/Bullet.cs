using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private float _bulletDestroyTime;

    private Vector3 _shootDir;
    private Transform _bulletTransform;
    private void Start()
    {
        _bulletTransform = GetComponent<Transform>();
    }
    public void Setup(Vector3 shootDir)
    {
        _shootDir = shootDir;
        transform.rotation = Quaternion.LookRotation(shootDir, Vector3.up);
        Destroy(gameObject, _bulletDestroyTime);
    }

    private void Update()
    {
        float speed = Mathf.Abs(_bulletSpeed);
        _bulletTransform.position += speed * Time.deltaTime * _shootDir;
    }

}
