using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CullingMaskControllerVR : MonoBehaviour
{
    [SerializeField] private Camera cam;
    void Awake()
    {
        Invoke("ChangeCullingMask", 10f);
    }

    void ChangeCullingMask()
    {
        cam.cullingMask =
            LayerMask.GetMask("Default", "TransparentFX", "Ignore Raycast", "NPC", "Water", "UI", "WhatIsGround",
                "OnlyVR", "Obstacles");
    }
}