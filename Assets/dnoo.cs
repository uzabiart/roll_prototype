using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private float collisionTime = 0f;
    private bool isColliding = false;
    private float requiredCollisionTime = 2f;

    private void OnCollisionEnter(Collision collision)
    {
        isColliding = true;
        collisionTime = Time.time;
    }

    private void OnCollisionExit(Collision collision)
    {
        isColliding = false;
        collisionTime = 0f;
    }

    private void Update()
    {
        if (isColliding && Time.time - collisionTime >= requiredCollisionTime)
        {
            // Wykryto kolizję po upływie wymaganego czasu
            Debug.Log("Kolizja!");
        }
    }
}
