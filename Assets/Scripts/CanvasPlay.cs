using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CanvasPlay : MonoBehaviour
{
    
    [SerializeField] GameObject CanvasPause;
    
    
    

    void Start()
    {
        
    }


    void Update()
    {
        
       
    }
    

    public void Pausa()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            CanvasPause.SetActive(true);
        }
    }

    public void FinJuego()
    {
        SceneManager.LoadScene(1);

    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
