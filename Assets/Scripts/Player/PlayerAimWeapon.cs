using UnityEngine;


public class PlayerAimWeapon : MonoBehaviour
{
    #region Datamembers

    #region Editor Settings

    [SerializeField] private LayerMask _groundMask;

    #endregion
    #region Private Fields

    private Camera _mainCamera;
    private Transform _aimTransform;

    #endregion

    #endregion


    #region Methods

    #region Unity Callbacks

    private void Start()
    {
        _mainCamera = Camera.main;
        _aimTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        Aim();
    }

    #endregion

    private void Aim()
    {
        var (success, position) = GetMousePosition();
        if (success)
        {
            var direction = position - _aimTransform.position;
            direction.y = 0;
            _aimTransform.forward = direction;
        }
    }

    private (bool success, Vector3 position) GetMousePosition()
    {
        var ray = _mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out var hitInfo, Mathf.Infinity, _groundMask))
        {

            return (success: true, position: hitInfo.point);
        }
        else
        {

            return (success: false, position: Vector3.zero);
        }
    }

    #endregion
}
