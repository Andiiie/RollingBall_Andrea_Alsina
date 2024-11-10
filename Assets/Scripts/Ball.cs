using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rb;

    float h, v;

    Vector3 direccion;
    [SerializeField] float velocity;
    [SerializeField] float fuerzaSalto;

    [SerializeField] float detectaSuelo = 0.15f;
    [SerializeField] LayerMask whatIsSuelo;

    [SerializeField] float vidas = 10;
    
    [SerializeField] float timer=180;
    [SerializeField] GameObject vcBack;
    [SerializeField] GameObject vcUp;
    [SerializeField] GameObject cam;

    [SerializeField] GameObject CanvasGameOver;
    [SerializeField] TMP_Text puntitosTxt;
    [SerializeField] TMP_Text TimerTxt;
    [SerializeField] GameObject aS;
    [SerializeField] AudioClip audioCollect;
    [SerializeField] AudioManager manaCoin;
    [SerializeField] int puntitos=0;
    [SerializeField] GameObject CanvasFinalJuego;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
      
    }

    
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        direccion.x = h;
        direccion.y = v;

        

        Salto();
        TiempoRestante();
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(h, 0, v).normalized * 0.1f, ForceMode.Impulse);

        rb.AddForce(new Vector3(h, 0, v).normalized * 0.1f, ForceMode.Force);
    }

    void Salto()
    {
        if(Input.GetKeyDown(KeyCode.Space) && DetectarSuelo() == true) 
        {
            rb.AddForce(new Vector3(0, 1, 0).normalized * fuerzaSalto, ForceMode.Impulse);
        }
    }

    bool DetectarSuelo()
    {
        bool Detector = Physics.Raycast(transform.position, new Vector3(0, -1, 0), detectaSuelo, whatIsSuelo);
        return Detector;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Rodillo")
        {
            vidas = 0;
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("camcamb"))
        {
            vcUp.SetActive(true);
            vcBack.SetActive(false);
            cam.SetActive(false);
        }
        if (other.gameObject.CompareTag("Coin"))
        {
            manaCoin.ReproducirSonido(audioCollect);
            puntitos++;
            puntitosTxt.SetText("Score: " + puntitos);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "DIE")
        {
            CanvasGameOver.SetActive(true);
            Muerte();
        }
        if(other.gameObject.tag == "FinalJuego")
        {
            CanvasFinalJuego.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("camcamb"))
        {
            vcUp.SetActive(false);
            vcBack.SetActive(true);
            cam.SetActive(true);
        }
    }

    void TiempoRestante()
    {
        TimerTxt.SetText("Timer: " + timer);
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            vidas = 0;
        }
    }
    void Muerte()
    {
        if (timer <= 0 || vidas <= 0)
        {
            CanvasGameOver.SetActive(true);
            aS.SetActive(false);
        }
    }
   

}
