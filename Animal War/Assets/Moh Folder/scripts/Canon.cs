using System;
using NUnit.Framework;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public float cooldown;
    public float nextShot;
    public GameObject bullet;
    public Transform bulletSpawn;
    public Transform barrel;
    void OnTriggerStay(Collider other)
    {
        //if !enemy return;
        if(Time.time >= nextShot && other.CompareTag("Enemy")){
            Transform barrel = transform.parent;
        Vector3 direction = other.transform.position - barrel.position;
        direction.y = 0;

        barrel.rotation = Quaternion.LookRotation(direction);
        Instantiate(bullet, barrel.position, barrel.rotation);
        Debug.Log("Shot");
        nextShot = Time.time + cooldown;
        }
    }
}
