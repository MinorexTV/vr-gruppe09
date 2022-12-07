using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NonVRMovement : MonoBehaviour
{  
    public float speed = 25f;
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
      moveDirection = move.ReadValue<Vector3>().normalized;

      if (moveDirection != Vector3.zero){
          transform.forward = moveDirection;
      }


      transform.position = new Vector3(
        Mathf.Clamp(transform.position.x, -24f, 24f),
        Mathf.Clamp(1, -24f, 24f),
        Mathf.Clamp(transform.position.z, -24f, 24f));
    }

 void FixedUpdate()
    {
    
  rb.velocity = new Vector3(moveDirection.x * speed, 0, moveDirection.z * speed);
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
