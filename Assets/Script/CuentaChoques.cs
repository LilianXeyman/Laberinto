using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CuentaChoques : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaFinal;

    [SerializeField]
    TextMeshProUGUI CuentaDeChoques;

    [SerializeField]
    GameObject pantallaMuerte;

    [SerializeField]
    TextMeshProUGUI numeroDeVidas;

    int numeroChoques = 0;
    int numeroVidas = 5;
    int numeroVidas2 = 5;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstaculo")
        {
            numeroChoques = numeroChoques + 1;
            Debug.Log("He chocado " + numeroChoques + " veces");
        }
        if (numeroChoques == numeroVidas)
        {
            pantallaMuerte.SetActive(true);
            gameObject.GetComponent<MovimientoJugador>().enabled = false;
        }
        if (collision.gameObject.tag == "Obstaculo")
        {
            numeroVidas2 = numeroVidas2 - 1;
            Debug.Log("Me quedan " + numeroVidas + " vidas");
        }
        numeroDeVidas.text = numeroVidas2.ToString();
    }
    private void OnTriggerEnter(Collider other)
    { 
        if (other.tag == "Meta")
        {
            CuentaDeChoques.text = numeroChoques.ToString();
            pantallaFinal.SetActive(true);
        }
    }
}
