using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodillo : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 direccionRot;
    [SerializeField] float direccionSpeed = 0.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddTorque(direccionRot * direccionSpeed, ForceMode.VelocityChange);
    }


    void FixedUpdate()
    {
        //rb.AddTorque(direccionRot * direccionSpeed, ForceMode.VelocityChange);

        //if (direccionSpeed >= 1)
        //{
        //    direccionSpeed == 1;
        //}
    }
}
