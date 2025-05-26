using UnityEngine;
public class Pitch : MonoBehaviour
{
    public float pitchForce = 5f;//Pitch force set
    private Rigidbody rb;
    private bool hasPitched = false;//Pitch tracker
    private Vector3 startPosition;//Ball start position
    private Quaternion startRotation;//Ball rotation satrt position
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
        startRotation = transform.rotation;
    }
    void Update()
    {
        if (!hasPitched && Input.GetKeyDown(KeyCode.Space))//Pitch ball with Space 
        {
            rb.AddForce(transform.forward * pitchForce, ForceMode.Impulse);
            hasPitched = true;
        }
        if (hasPitched && Input.GetKeyDown(KeyCode.R))//Reset ball for new pitch using key R
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            transform.position = startPosition;
            transform.rotation = startRotation;
            hasPitched = false;
        }
    }
}
