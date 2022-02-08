using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float fltTurningSpeed = 1f;
    float fltMovingSpeed = 0.01f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,fltTurningSpeed);
        transform.Translate(0,fltMovingSpeed,0);


    }
    
}
