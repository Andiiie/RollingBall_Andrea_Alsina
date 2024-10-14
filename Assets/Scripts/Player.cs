using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 direccion;
    float velocidad;

    [SerializeField] AudioClip sonidoMoneda;
    [SerializeField] AudioManager manager;

    void Start()
    {

    }


    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Colecccionable"))
        {
            manager.ReproducirSonido(sonidoMoneda);

            Destroy(other.gameObject);
        }
    }
}
