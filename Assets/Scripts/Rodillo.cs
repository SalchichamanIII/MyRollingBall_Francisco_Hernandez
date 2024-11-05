using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodillo : MonoBehaviour
{
    public float fuerzaRotacion = 2f; 
    public float velMaxAngular = 10f; 

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;              
        rb.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
        rb.maxAngularVelocity = velMaxAngular;
    }

    void FixedUpdate()
    {
       
        rb.AddTorque(transform.forward * fuerzaRotacion, ForceMode.VelocityChange);
    }
}
