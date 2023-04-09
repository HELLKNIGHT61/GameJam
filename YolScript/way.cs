using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class way : MonoBehaviour
{
    public GameObject _way; 
    bool yol_yapýldý; 

    private void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.CompareTag("mainCar") && yol_yapýldý == false)
        {
            Vector3 way_position = new Vector3(transform.position.x, transform.position.y + 10, transform.position.z); 
            Instantiate(_way, way_position, Quaternion.identity);
                                                                 
            yol_yapýldý = true;
            skor_manager.skor += 10;
            araba_controller.varsayilan_hiz += 0.3f;
            Destroy(this.gameObject, 4f);
        }
    }
}
