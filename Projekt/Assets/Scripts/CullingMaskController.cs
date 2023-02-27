using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CullingMaskController : MonoBehaviour
{
    public Camera vrcamera;
    public Camera nonvrcamera;
    public XRRayInteractor chooserL;
    public XRRayInteractor chooserR;

    void Awake()
    {
        if (GameManager.instance.firstround)
        {
            Invoke("ChangeCullingMask", 10f);
            Invoke("ChangeRaycastMask", 10f);
            GameManager.instance.ChangeFirstRound(false);
        }
        else
        {
            ChangeCullingMask();
            ChangeRaycastMask();
        }
    }

    void ChangeCullingMask()
    {
        nonvrcamera.cullingMask =
            LayerMask.GetMask("Default", "TransparentFX", "Ignore Raycast", "NPC", "Water", "UI", "WhatIsGround",
                "OnlyNonVR", "Obstacles");
        vrcamera.cullingMask = LayerMask.GetMask("Default", "TransparentFX", "Ignore Raycast", "NPC", "Water", "UI",
            "WhatIsGround",
            "OnlyVR", "Obstacles");
    }

    void ChangeRaycastMask()
    {
        chooserL.raycastMask = LayerMask.GetMask("NPC");
        chooserR.raycastMask = LayerMask.GetMask("NPC");
    }
}