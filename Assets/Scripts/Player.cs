using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    
    Vector3 direccion;
    float velocidad;
    int fuerza = 8;
    float h;
    float v;

    //[SerializeField] AudioClip sonidoMoneda;
    //[SerializeField] AudioManager manager;

    void Start()
    {

    }


    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 15, ForceMode.Impulse);
        }

        /*if ()
        {
            if(DetectarSuelo()) == true)
            {

            }
        }*/
    }

    //bool DetectarSuelo()
    //{
    //   //Physics.Raycast(transform.position, new Vector3(0, -1, 0), distanceDeteccionSuelo, queEsSuelo);
    //   //return detectado;
    //}

    private void FixedUpdate()
    {
        //rb.AddForce(new Vector3(h, 0, v).normalized * 8, ForceMode.Force);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Colecccionable"))
        {
            //manager.ReproducirSonido(sonidoMoneda);

            Destroy(other.gameObject);
        }
    }
}
