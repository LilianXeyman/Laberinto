using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorMeta : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaFinal;

  
    private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                Debug.Log("Has llegado a la meta");
                //pantallaFinal.SetActive(true);
                other.GetComponent<MovimientoJugador>().enabled = false;
            }
        }
   private void Update()
    {
        pantallaFinal.SetActive(false);
    }

}
