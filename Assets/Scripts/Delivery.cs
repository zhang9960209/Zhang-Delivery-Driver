using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("shit!");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        // if the thing triggered in the pkg, print out to console
        if (other.tag == "Pkg")
        {
             Debug.Log("Package picked up!");
        }
        if (other.tag == "Client")
        {
            Debug.Log("Package Delivered");
        }
    }
}
