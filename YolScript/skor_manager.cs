using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class skor_manager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI skor_tx;
    public static float skor;

    void Start()
    {
        skor = 0;
    }

    
    void Update()
    {
       
        skor_tx.text = skor.ToString();
    }

   
}
