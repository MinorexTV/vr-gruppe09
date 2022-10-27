using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NonVRMovement : MonoBehaviour
{  
    public float moveSpeed;
    public InputAction move;
    public Rigidbody rb;

    void OnEnable()
    {
       move.Enable();
    }

    void OnDisable()
    {
        move.Disable();
    }

    void Start()
    {
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 movementInput = move.ReadValue<Vector2>();
        rb.AddForce(movementInput.x * moveSpeed * Time.deltaTime, 0, movementInput.y * moveSpeed * Time.deltaTime);
    }
}
