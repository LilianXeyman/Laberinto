using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectorMeta : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaFinal;

    [SerializeField]
    TextMeshProUGUI textLabelTime;


float tiempoDeLaPartida = 0.0f;
    bool estaJugando = true;

    private void Update()
    {
        if (estaJugando == true)
        {
            tiempoDeLaPartida = tiempoDeLaPartida + Time.deltaTime;
        }
    } 

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Debug.Log("Has llegado a la meta");
            pantallaFinal.SetActive(true);
            other.GetComponent<MovimientoJugador>().enabled = false;
            //Debug.Log(tiempoDeLaPartida);
            estaJugando = false;
            textLabelTime.text = tiempoDeLaPartida.ToString();
        }
        
    }
    
}
