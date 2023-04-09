using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public float speed;
    public float range;
    float position;
    int direction = 1;


    void Start()
    {
        position = transform.position.y;


    }




    void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime * direction);
        if (transform.position.y <= position || transform.position.y >= (position + range))
        {
            direction *= -1;
        }


    }





}
