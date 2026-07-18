using System;
using UnityEngine;

public class visible : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        //if !enemy return;
        Transform barrel = transform.parent;
        Vector3 direction = other.transform.position - barrel.position;
        direction.y = 0;

        barrel.rotation = Quaternion.LookRotation(direction);
        Debug.Log("rotated");
    }
}
