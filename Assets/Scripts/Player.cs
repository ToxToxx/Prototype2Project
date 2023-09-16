using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }
    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private float rotatingSpeed = 60;
    [SerializeField] private float maxMovingSpeedCoef = 1.5f;
    [SerializeField] private Transform playerVisual;

    private float maxMovingSpeed;
    private float minMovingSpeed = 5f;


    private bool isRunning;
    private bool isWalking;

    private Rigidbody rb;
    private void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        if (!gameObject.IsDestroyed())
        {
            HandleMovement();
        }
        Vector2 inputVector = GameInput.Instance.GetMovementVectorNormalized();
        Vector3 moveDir = new(inputVector.x, 0f, 0f);
        isWalking = moveDir != Vector3.zero;

        transform.position += moveSpeed * Time.deltaTime * moveDir;
    }

    private void HandleMovement()
    {
        
        /*if (moveDir != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(moveDir, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotatingSpeed * Time.deltaTime);
        }*/
    }

}
