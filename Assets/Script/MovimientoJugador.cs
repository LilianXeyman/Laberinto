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
    }
}
