using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighscoreRotationController : MonoBehaviour
{
    public float rotationSpeed = 10.0f;

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}