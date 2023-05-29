using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aa : MonoBehaviour
{
     private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "dno")
        {
            Debug.Log("Collided with dno");
            // Display "ololo" on the screen (you can implement your specific logic here)
        }
    }
}
