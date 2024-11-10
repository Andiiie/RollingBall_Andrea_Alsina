using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Mov_Platform : MonoBehaviour
{
    [SerializeField] int velocidadMov = 3;
    [SerializeField] Vector3 Direccion = new Vector3 (0, 3, 0);
    [SerializeField] float timer = 1.0f;
    void Update()
    {
        transform.Translate (Direccion * velocidadMov * Time.deltaTime);
        timer += 1 * Time.deltaTime;

        if (timer >= 1.0f)
        {
            velocidadMov = - velocidadMov;
            timer = 0;
        }
    }
   
}
