using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidadMovimiento = 5f; // Velocidad de movimiento del objeto

    void Update()
    {
        // Captura el movimiento horizontal y vertical
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Combina los movimientos horizontal y vertical en un solo vector
        Vector3 movimiento = new Vector3(movimientoHorizontal, movimientoVertical, 0);

        // Normaliza el vector de movimiento para que tenga una longitud de 1
        // Esto asegura que la velocidad sea constante en todas las direcciones
        movimiento = movimiento.normalized;

        // Aplica el movimiento al objeto
        transform.Translate(movimiento * velocidadMovimiento * Time.deltaTime);
    }
}
