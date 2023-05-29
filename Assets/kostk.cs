using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kostk : MonoBehaviour
{
    // Start is called before the first frame update
    public float rollForce = 1f;
    void Start()
    {
        Vector3 randomDirection = Random.insideUnitSphere.normalized;

        // Apply a force to roll the object in the random direction
        GetComponent<Rigidbody>().AddForce(randomDirection * rollForce, ForceMode.Impulse);
    }

    // Update is called once per frame
   
}
