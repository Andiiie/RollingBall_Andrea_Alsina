using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource spotty;

    public void ReproducirSonido(AudioClip clip)
    {
        //Ejecuta el clip introducido por par�metro de entreada
        spotty.PlayOneShot(clip);
    }
}
