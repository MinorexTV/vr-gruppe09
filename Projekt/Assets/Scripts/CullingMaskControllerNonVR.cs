using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CullingMaskControllerNonVR : MonoBehaviour
{
    void Start()
    {
        Invoke("ChangeCullingMask", 10f);
    }

    void ChangeCullingMask()
    {
        GetComponent<Camera>().cullingMask =
            LayerMask.GetMask("Default", "TransparentFX", "Ignore Raycast", "NPC", "Water", "UI", "WhatIsGround",
                "OnlyNonVR", "Obstacles");
    }
}