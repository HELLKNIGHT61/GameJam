using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class way : MonoBehaviour
{
    public GameObject _way; 
    bool yol_yap�ld�; 

    private void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.CompareTag("mainCar") && yol_yap�ld� == false)
        {
            Vector3 way_position = new Vector3(transform.position.x, transform.position.y + 10, transform.position.z); 
            Instantiate(_way, way_position, Quaternion.identity);
                                                                 
            yol_yap�ld� = true;
            skor_manager.skor += 10;
            araba_controller.varsayilan_hiz += 0.3f;
            Destroy(this.gameObject, 4f);
        }
    }
}
