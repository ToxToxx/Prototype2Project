using UnityEngine;

public class PlayerShootProjectile : MonoBehaviour
{
    [SerializeField] private Transform _gunEndPosition;
    [SerializeField] private Transform _gunStartPosition;
    [SerializeField] private Transform _pfBullet;
    private void Start()
    {
        GameInput.Instance.OnShoot += GameInput_OnShoot;
    }

    private void GameInput_OnShoot(object sender, System.EventArgs e)
    {
        Transform bulletTransform = Instantiate(_pfBullet, transform.position, Quaternion.identity);

        Vector3 shootDir = (_gunEndPosition.position - _gunStartPosition.position).normalized;
        bulletTransform.GetComponent<Bullet>().Setup(shootDir);
    }

    private void OnDestroy()
    {
        GameInput.Instance.OnShoot -= GameInput_OnShoot;
    }
}
