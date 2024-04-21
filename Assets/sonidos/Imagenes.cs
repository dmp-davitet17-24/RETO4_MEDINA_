using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Imagenes : MonoBehaviour
{

    public GameObject[] imag;
    int index;
    void Start()
    {
        index = 0;
    }

    void Update()
    {
        if (index >= 3)
        
            index = 3;

        if (index < 0)
            index = 0;

        if(index == 0)
        {
            imag[0].gameObject.SetActive(true);
        }
        
    }

   
    public void NextTitle()
    {
        index += 1;
        if (index > imag.Length -1)
        {
            index = 0;

        }
        for (int i = 0; i < imag.Length; i++)
        {
            imag[i].gameObject.SetActive(false);
            imag[index].gameObject.SetActive(true);
            
        }
      
        Debug.Log(index);
    }
    public void PreviusTitle()
    {
        index -= 1;
        if (index < 0)
        {
            index = imag.Length-1;
        }
        for (int i = 0; i < imag.Length; i++)
        {
            imag[i].gameObject.SetActive(false);
            imag[index].gameObject.SetActive(true);

        }
        
      
        Debug.Log(index);
    }
}
