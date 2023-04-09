using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitap : MonoBehaviour
{
    public Transform ellen;
    bool update = true;
    public Transform finish;
    void Start()
    {
        ellen = GameObject.Find("Ellen").GetComponent<Transform>();
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (update)
        {
            Vector2 alp = new Vector2(ellen.position.x + 5f, ellen.position.y + 3f);
            transform.position = alp;
            Sinir();
            
        }
        
    }

    void Sinir()
    {
        if(transform.position.x >= finish.position.x)
        {
            update = false;
        }
    }

}
