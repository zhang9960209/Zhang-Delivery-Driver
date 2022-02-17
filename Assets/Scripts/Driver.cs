using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float fltTurningSpeed = 1f;
    [SerializeField] float fltMovingSpeed = 0.1f;
    [SerializeField] float fltBoostspeed = 20f;
    [SerializeField] float fltSlowSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        float fltMoveAmount = Input.GetAxis("Vertical") * fltMovingSpeed * Time.deltaTime;
        float fltSteerAmount = Input.GetAxis("Horizontal") * fltTurningSpeed * Time.deltaTime;
        transform.Rotate(0,0,-fltSteerAmount);
        transform.Translate(0,fltMoveAmount,0);


    }
    
    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.tag == "boost")
        {
            fltMovingSpeed = fltBoostspeed;
        }
    }
    
    void OnCollisionEnter2D (Collision2D other)
    {
        fltMovingSpeed = fltSlowSpeed;
    }
}
