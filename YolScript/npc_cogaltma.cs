using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_cogaltma : MonoBehaviour
{
    public GameObject random_car_spawn;
    bool car_spawn = true;

    void Start()
    {
        StartCoroutine(bekle()); //Önemli bir nokta da, eðer bu bekletme iþlemini saðlamak istiyorsak, fonksiyonlarý StartCoroutine isimli fonksiyon aracýlýðýyla
                                 // çaðýrmamýz gerekli.Eðer direkt oluþturduðunuz IEnumerator tipindeki fonksiyonu çaðýrýrsanýz, bekleme iþlemi çalýþmayacaktýr.
    }

    IEnumerator bekle()// Update veya FixedUpdate fonksiyonlarýný düþündüðümüzde, bunlar her karede çaðrýlan fonksiyonlardýr.Coroutine fonksiyonlarý
                       //  ile bizim yaptýðýmýzda bu sürekli çaðrýlma durumu yerine, verdiðimiz sürelerde beklemeye geçip,komutlarýmýzýn çalýþmasýný saðlamaktadýr                  
    {
        while (car_spawn == true)
        {
            Instantiate(random_car_spawn, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.8f);// bir sn de bir çalýþtýr fonksiyonu
        }
    }
}
