using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_cogaltma : MonoBehaviour
{
    public GameObject random_car_spawn;
    bool car_spawn = true;

    void Start()
    {
        StartCoroutine(bekle()); //�nemli bir nokta da, e�er bu bekletme i�lemini sa�lamak istiyorsak, fonksiyonlar� StartCoroutine isimli fonksiyon arac�l���yla
                                 // �a��rmam�z gerekli.E�er direkt olu�turdu�unuz IEnumerator tipindeki fonksiyonu �a��r�rsan�z, bekleme i�lemi �al��mayacakt�r.
    }

    IEnumerator bekle()// Update veya FixedUpdate fonksiyonlar�n� d���nd���m�zde, bunlar her karede �a�r�lan fonksiyonlard�r.Coroutine fonksiyonlar�
                       //  ile bizim yapt���m�zda bu s�rekli �a�r�lma durumu yerine, verdi�imiz s�relerde beklemeye ge�ip,komutlar�m�z�n �al��mas�n� sa�lamaktad�r                  
    {
        while (car_spawn == true)
        {
            Instantiate(random_car_spawn, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.8f);// bir sn de bir �al��t�r fonksiyonu
        }
    }
}
