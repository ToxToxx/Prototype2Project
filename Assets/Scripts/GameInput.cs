using System;
using UnityEngine;


public class GameInput : MonoBehaviour
{
    public static GameInput Instance { get; private set; }

    private PlayerInputActions _playerInputActions;

    public event EventHandler OnShoot;
    public event EventHandler OnHeal;
    void Awake()
    {
        gameObject.SetActive(true);

        Instance = this;

        _playerInputActions = new PlayerInputActions();

        _playerInputActions.Player.Enable();

        _playerInputActions.Player.Shoot.performed += Shoot_performed;
        _playerInputActions.Player.Heal.performed += Heal_performed;
        
    }
    private void Start()
    {
        GameOverManager.Instance.GameIsOver += GameOverManager_GameIsOver;

    }


    private void GameOverManager_GameIsOver(object sender, EventArgs e)
    {
        gameObject.SetActive(false);
        _playerInputActions.Player.Shoot.performed -= Shoot_performed;
        _playerInputActions.Player.Heal.performed -= Heal_performed;

        _playerInputActions.Dispose();
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
        Vector2 inputVector = _playerInputActions.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;
        return inputVector;
    }

    private void OnDestroy()
    {
        _playerInputActions.Player.Shoot.performed -= Shoot_performed;
        _playerInputActions.Player.Heal.performed -= Heal_performed;

        _playerInputActions.Dispose();
    }
}
