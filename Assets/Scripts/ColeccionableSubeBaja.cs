using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColeccionableSubeBaja : MonoBehaviour
{
    [SerializeField] float velocidadMov = 1;
    [SerializeField] Vector3 Direccion = new Vector3(0, 3, 0);
    [SerializeField] float timer = 0.5f;
    void Update()
    {
        transform.Translate(Direccion * velocidadMov * Time.deltaTime);
        timer += 1 * Time.deltaTime;

        if (timer >= 0.5f)
        {
            velocidadMov = -velocidadMov;
            timer = 0;
        }
    }
}
