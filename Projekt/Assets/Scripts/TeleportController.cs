using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
public class TeleportController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject baseController;
     [SerializeField]GameObject teleportController;

     [SerializeField] InputActionReference teleportActivateRef;
    void Start()
    {
       teleportActivateRef.action.performed += ActivateController;
       teleportActivateRef.action.canceled += DeactivateController;
    }

    void ActivateController(InputAction.CallbackContext ctx){
        baseController.SetActive(false);
        teleportController.SetActive(true);
    }
    void DeactivateController(InputAction.CallbackContext ctx){
        baseController.SetActive(true);
        teleportController.SetActive(false);
    }
}
