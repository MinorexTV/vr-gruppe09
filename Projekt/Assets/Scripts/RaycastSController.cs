using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class RaycastSController : MonoBehaviour
{
    void Start()
    {
        Invoke("ChangeRaycastMask", 8.5f);
    }

    void ChangeRaycastMask()
    {
        GetComponent<XRRayInteractor>().raycastMask = LayerMask.GetMask("NPC");
    }
}