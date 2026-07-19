using System;
using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{    
    public float speed = 5f;
    public Vector3 direction = Vector3.right;
    private Rigidbody rb;
    public int hp;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = direction.normalized * speed;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (!other.CompareTag("proj")) return;

        if (hp < 0)
        {
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("HP: " + hp);
            hp--;
            Debug.Log("HP: " + hp);
        }
    }
}
