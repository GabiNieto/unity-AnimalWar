using UnityEngine;

public class test : MonoBehaviour
{    
    public float speed = 5f;
    public Vector3 direction = Vector3.right;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = direction.normalized * speed;
    }
}
