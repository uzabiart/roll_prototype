using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dno : MonoBehaviour
{
    private bool czy_kolizja = false;
    private float od_teraz = 0f;
    private float po_tylu = 2f;
    private Collision currentCollision;
    private bool wyswietlil = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("dno"))
        {
            czy_kolizja = true;
            od_teraz = Time.time;
            currentCollision = collision;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (gameObject.CompareTag("dno"))
        {
            czy_kolizja = false;
            od_teraz = 0f;
            currentCollision = null;
            wyswietlil = false;
        }
    }

    private void Update()
    {
        if (czy_kolizja && Time.time - od_teraz >= po_tylu && !wyswietlil)    //jak( od "teraz" - punkt rozpoczęcia > 2 sek i nie wyswietlil)
        {
            
            if (gameObject.CompareTag("dno") && currentCollision != null)
            {
                foreach (ContactPoint contact in currentCollision.contacts)
                {
                    if (contact.otherCollider.CompareTag("a"))
                    {
                        Debug.Log("blue");
                        wyswietlil = true;
                    }
                    else if (contact.otherCollider.CompareTag("b"))
                    {
                        Debug.Log("żaby");
                        wyswietlil = true;
                    }
                    else if (contact.otherCollider.CompareTag("c"))
                    {
                        Debug.Log("+3");
                        wyswietlil = true;
                    }
                    else if (contact.otherCollider.CompareTag("d"))
                    {
                        Debug.Log("+2");
                        wyswietlil = true;
                    }
                    else if (contact.otherCollider.CompareTag("e"))
                    {
                        Debug.Log("+1");
                        wyswietlil = true;
                    }
                    else if (contact.otherCollider.CompareTag("f"))
                    {
                        Debug.Log("+1");
                        wyswietlil = true;
                    }
                }
            }
        }
    }
}
