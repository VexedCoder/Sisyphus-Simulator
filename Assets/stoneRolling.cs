using UnityEngine;

public class stoneRolling : MonoBehaviour
{
    public GameObject stone;
    private Rigidbody stoneRb;
    private Vector3 previousHandPosition;
    public float forceMultiplier = 5.0f;
    
    void Start()
    {
        stoneRb = stone.GetComponent<Rigidbody>();
        previousHandPosition = transform.position;
    }
    
    void Update()
    {
        Vector3 handMovement = transform.position - previousHandPosition;
        
        // Detect upward movement
        if (handMovement.y > 0.01f)
        {
            // Apply upward force
            stoneRb.AddForce(Vector3.up * handMovement.y * forceMultiplier, ForceMode.Force);
        }
        
        // Detect forward movement
        if (handMovement.z > 0.01f)
        {
            // Apply forward/rolling force
            stoneRb.AddForce(Vector3.forward * handMovement.z * forceMultiplier, ForceMode.Force);
        }
        
        previousHandPosition = transform.position;
    }
}