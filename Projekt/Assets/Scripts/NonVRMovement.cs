using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class NonVRMovement : MonoBehaviour
{
    public float speed = 25f;
    public InputAction move;
    public Rigidbody rb;
    public LayerMask obstacles;
    Vector3 moveDirection = Vector3.zero;

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
        Vector3 randomSpawnPosition = new Vector3(randomFloat(-24f, +24f), 0, randomFloat(-24f, +24f));
        if (!Physics.CheckSphere(randomSpawnPosition, 3, obstacles))
        {
            transform.position += randomSpawnPosition;
        }
        else
        {
            Debug.Log("Hit Obstacle");
            Start();
        }
    }

    void Update()
    {
        moveDirection = move.ReadValue<Vector3>().normalized;

        if (moveDirection != Vector3.zero)
        {
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

    static float randomFloat(float min, float max)
    {
        System.Random random = new System.Random();
        double val = (random.NextDouble() * (max - min) + min);
        return (float)val;
    }
}