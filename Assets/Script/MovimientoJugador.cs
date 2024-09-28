using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float movimientoX;
    public float movimientoY;
    public float movimientoZ;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movimientoX, movimientoY, movimientoZ);
    }
}
