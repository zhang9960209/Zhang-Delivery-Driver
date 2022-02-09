using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float fltTurningSpeed = 1f;
    [SerializeField] float fltMovingSpeed = 0.01f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        float fltMoveAmount = Input.GetAxis("Vertical") * fltMovingSpeed;
        float fltSteerAmount = Input.GetAxis("Horizontal") * fltTurningSpeed;
        transform.Rotate(0,0,-fltSteerAmount);
        transform.Translate(0,fltMoveAmount,0);


    }
    
}
