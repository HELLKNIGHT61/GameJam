using System.Collections;
using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class text1 : MonoBehaviour
{
    public float delay = 0.065f;
    [Multiline]
    public string yazi;

   
    TextMeshProUGUI thisText;

    private void Start()
    {
        thisText = GetComponent<TextMeshProUGUI>();

        StartCoroutine(TypeWrite());
    }

    IEnumerator TypeWrite()
    {
        foreach (char i in yazi)
        {
            thisText.text += i.ToString();
            if (i.ToString() == ".") { yield return new WaitForSeconds(1); }
            else { yield return new WaitForSeconds(delay); }
        }
    }
}