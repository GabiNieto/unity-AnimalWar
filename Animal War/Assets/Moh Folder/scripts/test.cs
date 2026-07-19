using System;
using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{    
    public float speed = 5f;
    public Vector3 direction = Vector3.right;
    private Rigidbody rb;
    public float hp;

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
        WeaponBP wpn = other.GetComponent<WeaponBP>();
        if (!other.CompareTag("proj") || wpn == null ) return;

        hp -= wpn.dmg;

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
