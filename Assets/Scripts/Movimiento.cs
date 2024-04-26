using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
     public float velocidadMovimiento = 5f; // Velocidad de movimiento del objeto
 
     void Update()
     {
         // Movimiento horizontal (izquierda y derecha)
         float movimientoHorizontal = Input.GetAxis("Horizontal");
         transform.Translate(Vector3.right * movimientoHorizontal * velocidadMovimiento * Time.deltaTime);
 
         // Movimiento vertical (arriba y abajo)
         float movimientoVertical = Input.GetAxis("Vertical");
         transform.Translate(Vector3.up * movimientoVertical * velocidadMovimiento * Time.deltaTime);
     }

}
