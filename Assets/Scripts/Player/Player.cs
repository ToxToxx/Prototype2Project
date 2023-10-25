using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }

    [SerializeField] private float _moveSpeed = 12;
    [SerializeField] private float _rotatingSpeed = 60;
    [SerializeField] private Transform _playerVisual;

    private readonly int _movingRangeX = 23;
    private Transform _playerTransform;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _playerTransform = GetComponent<Transform>();
    }
    void Update()
    {
        if (!gameObject.IsDestroyed())
        {
            HandleMovement();
        }
       
    }

    private void HandleMovement()
    {
        if (_playerTransform.position.x > _movingRangeX)
        {
            _playerTransform.position = new Vector3(_movingRangeX, _playerTransform.position.y, _playerTransform.position.z);
        }
        else if (_playerTransform.position.x < -_movingRangeX)
        {
            _playerTransform.position = new Vector3(-_movingRangeX, _playerTransform.position.y, _playerTransform.position.z);
        }
        else
        {
            Vector2 inputVector = GameInput.Instance.GetMovementVectorNormalized();
            Vector3 moveDir = new(inputVector.x, 0f, 0f);

            _playerTransform.position += _moveSpeed * Time.deltaTime * moveDir;
            
            if (moveDir != Vector3.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(moveDir, Vector3.up);
                _playerTransform.rotation = Quaternion.RotateTowards(_playerTransform.rotation, toRotation, _rotatingSpeed * Time.deltaTime);
            }
        }
    }
}
