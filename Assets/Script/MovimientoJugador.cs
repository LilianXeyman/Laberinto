using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovimientoJugador : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI CuentaFinalMonedas;

    [SerializeField]
    GameObject pantallaFinal;

    public float movimientoX;
    public float movimientoY;
    public float movimientoZ;
    public float velocidadMovimiento = 1.5f;
    
    public int cuentaDeMonedas = 0;
   
    public AudioClip coinSFX;
    public AudioClip SpecialcoinSFX;

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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Debug.Log("He cogido una moneda");
            other.gameObject.SetActive(false);
            cuentaDeMonedas = cuentaDeMonedas + 1;
            Debug.Log("Tienes " + cuentaDeMonedas + " monedas");
            AudioSource.PlayClipAtPoint(coinSFX, transform.position);
        }
        if (other.CompareTag("SpecialCoin"))
        {
            Debug.Log("He congido una moneda especial");
            other.gameObject.SetActive(false);
            cuentaDeMonedas = cuentaDeMonedas + 5;
            Debug.Log("Tienes " + cuentaDeMonedas + " monedas");
            AudioSource.PlayClipAtPoint(SpecialcoinSFX, transform.position);
        }
        if (other.tag == "Meta")
        {
            pantallaFinal.SetActive(true);
            CuentaFinalMonedas.text = cuentaDeMonedas.ToString();
        }
    }
}
