using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class TeleportController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject baseController;
    [SerializeField] GameObject actionController;

    [SerializeField] InputActionReference actionActivateRef;

    void Start()
    {
        actionActivateRef.action.performed += ActivateController;
        actionActivateRef.action.canceled += DeactivateController;
    }

    void ActivateController(InputAction.CallbackContext ctx)
    {
        baseController.SetActive(false);
        actionController.SetActive(true);
    }

    void DeactivateController(InputAction.CallbackContext ctx)
    {
        baseController.SetActive(true);
        actionController.SetActive(false);
    }
}