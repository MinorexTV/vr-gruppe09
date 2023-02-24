using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCircleController : MonoBehaviour
{
    public Transform target; 
    public float radius = 10.0f; 
    public float speed = 2.0f; 
    public float height = 1.0f; 

    private Vector3 offset; 

    void Start()
    {
        offset = transform.position - target.position; 
    }

    void Update()
    {
        // Die Position der Kamera berechnen
        float angle = Time.time * speed;
        Vector3 position = new Vector3(Mathf.Sin(angle), 0.0f, Mathf.Cos(angle)) * radius;
        transform.position = target.position + position + new Vector3(0.0f, height, 0.0f);

        // Die Kamera auf das Zielobjekt ausrichten
        transform.LookAt(target.position);
    }
}
