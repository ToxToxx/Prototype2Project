using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameInput : MonoBehaviour
{
    public static GameInput Instance { get; private set; }
    private PlayerInputActions playerInputActions;
    public event EventHandler OnShoot;
    public event EventHandler OnHeal;
    void Awake()
    {
        gameObject.SetActive(true);
        Instance = this;
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        playerInputActions.Player.Shoot.performed += Shoot_performed;
        playerInputActions.Player.Heal.performed += Heal_performed;
        
    }
    private void Start()
    {
        GameOverManager.Instance.GameIsOver += GameOverManager_GameIsOver;

    }


    private void GameOverManager_GameIsOver(object sender, EventArgs e)
    {
        gameObject.SetActive(false);
    }

    private void Heal_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnHeal?.Invoke(this, EventArgs.Empty);
    }

    private void Shoot_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnShoot?.Invoke(this, EventArgs.Empty);
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;
        return inputVector;
    }

    private void OnDestroy()
    {
        playerInputActions.Player.Shoot.performed -= Shoot_performed;
        playerInputActions.Player.Heal.performed -= Heal_performed;

        playerInputActions.Dispose();
    }
}
