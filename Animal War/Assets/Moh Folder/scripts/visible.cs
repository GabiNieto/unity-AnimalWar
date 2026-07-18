using System;
using UnityEngine;

public class visible : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //if !enemy return;
        Debug.Log("Seen"); // TESTING PURPOSES
    }
}
