using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }
    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private float rotatingSpeed = 60;
    [SerializeField] private Transform playerVisual;
    private int movingRangeX = 23;

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
       
    }

    private void HandleMovement()
    {
        if (transform.position.x > movingRangeX)
        {
            transform.position = new Vector3(movingRangeX, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -movingRangeX)
        {
            transform.position = new Vector3(-movingRangeX, transform.position.y, transform.position.z);
        }
        else
        {
            Vector2 inputVector = GameInput.Instance.GetMovementVectorNormalized();
            Vector3 moveDir = new(inputVector.x, 0f, 0f);

            transform.position += moveSpeed * Time.deltaTime * moveDir;
            
            if (moveDir != Vector3.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(moveDir, Vector3.up);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotatingSpeed * Time.deltaTime);
            }
        }
    }
}
