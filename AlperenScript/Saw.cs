using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{

    public float speed;
    public float range;
    float position;
    int direction = 1;
    


    void Start()
    {
        position = transform.position.x;


    }

        
    void FixedUpdate()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime * direction);
        if (transform.position.x <= position || transform.position.x >= (position + range))
        {
            direction *= -1;

           
        }

        

    }

   


}
