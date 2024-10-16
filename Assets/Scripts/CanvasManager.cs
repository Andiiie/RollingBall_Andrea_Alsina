using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
   public void EmpezarPartida()
    {
        //Cargar escena 1
        SceneManager.LoadScene(1);
    }

    public void TerminarJuego()
    {
        //SOLO FUNCIONA EN EL EJECUTABLE
        Application.Quit();
    }
}
