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

    int numeroChoques = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstaculo")
        {
            numeroChoques = numeroChoques + 1;
            Debug.Log("He chocado " + numeroChoques + " veces");
        }
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
