using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scian : MonoBehaviour
{
    public GameObject parentObject;

    private void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null && parentObject != null)
        {
            FixedJoint joint = parentObject.AddComponent<FixedJoint>();
            joint.connectedBody = rb;
        }
    }
}