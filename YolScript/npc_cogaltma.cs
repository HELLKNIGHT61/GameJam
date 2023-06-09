using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_cogaltma : MonoBehaviour
{
    public GameObject random_car_spawn;
    bool car_spawn = true;

    void Start()
    {
        StartCoroutine(bekle()); //Önemli bir nokta da, eğer bu bekletme işlemini sağlamak istiyorsak, fonksiyonları StartCoroutine isimli fonksiyon aracılığıyla
                                 // çağırmamız gerekli.Eğer direkt oluşturduğunuz IEnumerator tipindeki fonksiyonu çağırırsanız, bekleme işlemi çalışmayacaktır.
    }

    IEnumerator bekle()// Update veya FixedUpdate fonksiyonlarını düşündüğümüzde, bunlar her karede çağrılan fonksiyonlardır.Coroutine fonksiyonları
                       //  ile bizim yaptığımızda bu sürekli çağrılma durumu yerine, verdiğimiz sürelerde beklemeye geçip,komutlarımızın çalışmasını sağlamaktadır                  
    {
        while (car_spawn == true)
        {
            Instantiate(random_car_spawn, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.8f);// bir sn de bir çalıştır fonksiyonu
        }
    }
}
