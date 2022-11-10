using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NonVRMovement : MonoBehaviour
{  
    public float speed = 2.5f;
    public InputAction move;
    public Rigidbody rb;

Vector3 moveDirection = Vector3.zero;

    void OnEnable()
    {
       move.Enable();
    }

    void OnDisable()
    {
        move.Disable();
    }


  void Update()
    {
      moveDirection = move.ReadValue<Vector3>();
    }

 void FixedUpdate()
    {
    
  rb.velocity = new Vector3(moveDirection.x * speed, moveDirection.y * speed , moveDirection.z * speed);
    }
/*
    void Start()
    {
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 movementInput = move.ReadValue<Vector2>();
        rb.AddForce(movementInput.x * moveSpeed * Time.deltaTime, 0, movementInput.y * moveSpeed * Time.deltaTime);
    }  */

    
}
