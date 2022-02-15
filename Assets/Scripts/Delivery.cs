using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool blGetPackage;
    [SerializeField] float flDetroyDelay = 0.5f;
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("shit!");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        // if the thing triggered in the pkg, print out to console
        if (other.tag == "Pkg" && !blGetPackage)
        {
             Debug.Log("Package picked up!");
             blGetPackage = true;
             Destroy(other.gameObject, flDetroyDelay);
        }
        if (other.tag == "Client" && blGetPackage)
        {
            Debug.Log("Package Delivered");
            blGetPackage = false;
        }
    }
}
