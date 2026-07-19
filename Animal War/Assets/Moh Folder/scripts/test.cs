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

    //cube attacked
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Game obj: "+other.gameObject);

        if (!other.CompareTag("proj")) return;

        Destroy(other); // supposed to remove bullet (may not work)
        Debug.Log("HP: " + hp);
        hp--;
        Debug.Log("HP: " + hp);

        if (hp < 0)
        {
            Destroy(gameObject);
        }
    }
}
