using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muro : MonoBehaviour
{
    [SerializeField] private Rigidbody[] rbs;
    float timer = 1f;
    bool timerStart = false;
    void Start()
    {
        rbs = GetComponentsInChildren<Rigidbody>();
    }

    void Update()
    {
        if (timerStart == true)
        {
            timer += 1 * Time.unscaledDeltaTime;
            if (timer >= 2f)
            {
                Time.timeScale = 1f;
                for (int i = 0; i < 35; i++)
                {
                    timerStart = false; 
                }

            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            timerStart = true;
            Time.timeScale = 0.25f;
        }

    }
}
