using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Platform : MonoBehaviour
{
    [SerializeField] int movimientoPlatform;
    [SerializeField] Vector3 Direccion = new Vector3 (0, 0, 0);
    void Update()
    {
        transform.Translate (Direccion * movimientoPlatform * Time.deltaTime); 
    }
   
}
