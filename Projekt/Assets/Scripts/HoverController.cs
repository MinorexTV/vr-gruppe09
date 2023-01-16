using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class HoverController : MonoBehaviour
{
    // The maximum height that the object will reach as it hovers
    public float maxHeight = 1.0f;

    // The speed at which the object will hover up and down
    public float hoverSpeed = 1.0f;

    // The speed at which the object will spin
    public float spinSpeed = 1.0f;

    public float randomRange = 5.0f;

    public AudioClip coin;

    // The initial position of the object
    private Vector3 initialPosition;

    void Start()
    {
        // Save the initial position of the object
        initialPosition = transform.position;

        // Generate random x and z values within a range of 0-5
        float randomX = Random.Range(0.0f, randomRange);
        float randomZ = Random.Range(0.0f, randomRange);

        // Add the random x and z values to the initial position
        initialPosition.x += randomX;
        initialPosition.z += randomZ;

        coin = GetComponent<AudioSource>().clip;

        // Set the object's position to the initial position
        transform.position = initialPosition;

        // Add a Rigidbody component to the object
        Rigidbody rb = gameObject.AddComponent<Rigidbody>();
        
        // Set the Rigidbody's drag and angular drag to 0 so that it doesn't slow down
        rb.mass = 1;
        rb.drag = 0;
        rb.angularDrag = 0;

        rb.isKinematic=true;
    }

    void Update()
    {
        // Calculate the new vertical position of the object
        float newYPos = initialPosition.y + Mathf.Sin(Time.time * hoverSpeed) * maxHeight;

        // Update the object's position
        transform.position = new Vector3(transform.position.x, newYPos, transform.position.z);

        // Rotate the object around its up axis (the y-axis in this case)
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("NonVRPlayer"))

        {
            GameManager.instance.collectible();
            AudioSource.PlayClipAtPoint(coin, transform.position);
            Destroy(gameObject);
            //PlayParticle();
        }
    }
}