using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Follow : MonoBehaviour
{

    [SerializeField] GameObject cam;
    [SerializeField] GameObject background;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    void LateUpdate()
    {
        cam.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 10.0f);
        background.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 10.0f);
    }


}
