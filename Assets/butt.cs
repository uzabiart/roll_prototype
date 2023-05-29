using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class butt : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject kostka;
     public GameObject kostka2;
     public GameObject kostka3;
     public GameObject kostka4;
    void Start()
    {
        Button przycisk = GetComponent<Button>();
        przycisk.onClick.AddListener(Klik);
    }

    // Update is called once per frame
   private void Klik()
   {
         kostka.SetActive(true);
         kostka2.SetActive(true);
         kostka3.SetActive(true);
         kostka4.SetActive(true);
         
   }
}
