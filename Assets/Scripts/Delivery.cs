using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool blGetPackage;
    SpriteRenderer spriteRenderer;
    [SerializeField] float flDetroyDelay = 0.5f;
    [SerializeField] Color32 getPkgColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPkgColor = new Color32(1,1,1,1);
    
    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
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
             spriteRenderer.color = getPkgColor;
             Destroy(other.gameObject, flDetroyDelay);
        }
        if (other.tag == "Client" && blGetPackage)
        {
            Debug.Log("Package Delivered");
            blGetPackage = false;
            spriteRenderer.color = noPkgColor;
        }
    }
}
