using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float movimientoX;
    public float movimientoY;
    public float movimientoZ;
    public float velocidadMovimiento = 1.5f;
    /*[SerializeField]
    GameObject pantallaFinal;*/

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        movimientoX=-Input.GetAxis("Horizontal")*Time.deltaTime*velocidadMovimiento;
        movimientoZ = -Input.GetAxis("Vertical")*Time.deltaTime*velocidadMovimiento;
        transform.Translate(movimientoX, movimientoY, movimientoZ);
        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(0, -90, 0);
        }
        if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(0, 90, 0);
        }
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Meta")
        pantallaFinal.SetActive(true);

    }*/
}
