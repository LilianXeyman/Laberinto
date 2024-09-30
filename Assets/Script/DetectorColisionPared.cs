using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectorColisionPared : MonoBehaviour
{
    [SerializeField]
    Material newMaterial2;

    [SerializeField]
    Material paredTocada;

    [SerializeField]
    TextMeshProUGUI CuentaChoques;

    [SerializeField]
    GameObject pantallaFinal;

    int numeroChoques = 0;

    bool paredVioleta = false;

    float tiempoVioleta = 5f;
    //Funcion que se ejecuta cada vez por imagen del juego
    private void Update()
    {
        if(paredVioleta==true)
        {
            tiempoVioleta = tiempoVioleta - Time.deltaTime;
            if (tiempoVioleta < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = newMaterial2;
                paredVioleta = false;
                tiempoVioleta = 5f;
            }
        }
    }
    //Funcion que se ejecuta cada vez que haya una colision con este gameObject
    private void OnCollisionEnter(Collision collision)
    {
      
        if(collision.gameObject.tag == "Player")
        {
            numeroChoques = numeroChoques + 1;
            Debug.Log(collision.gameObject.name);
            gameObject.GetComponent<MeshRenderer>().material = paredTocada;
            paredVioleta = true;
        }
        if (collision.gameObject.tag=="Meta")
        {
            pantallaFinal.SetActive(true);
            CuentaChoques.text = numeroChoques.ToString();
        }
    }

}
