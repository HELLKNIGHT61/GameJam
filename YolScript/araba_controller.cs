using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class araba_controller : MonoBehaviour
{

    public static float yatay_hiz = 4f, dikey_hiz = 4f, varsayilan_hiz = 5f;
    float dikey_hareket, yatay_hareket;

  
    Rigidbody2D rb2d; 
    void Start()
    {
        varsayilan_hiz = 4;
        rb2d = GetComponent<Rigidbody2D>();
    }

 
    void FixedUpdate()
    {
        dikey_hareket = Input.GetAxis("Vertical");
        yatay_hareket = Input.GetAxis("Horizontal"); 

        rb2d.velocity = new Vector3 
        (yatay_hiz * yatay_hareket * 50 * Time.deltaTime, varsayilan_hiz + dikey_hareket * 50 * dikey_hiz * Time.deltaTime,0); 
        if(transform.position.x > 1.9f) 
        {
            Vector3 right_limit = new Vector3(1.9f, transform.position.y);
            transform.position = right_limit;
           
        }

        if (transform.position.x < -1.85f) 
        {
            Vector3 left_limit = new Vector3(-1.85f, transform.position.y);
            transform.position = left_limit;
            
        }
    }
}
