using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta1 : MonoBehaviour
{

    public numeroRND numeroRND;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("p1"))
        {

            if (numeroRND.hasKey == 3)
            {

                if (numeroRND.door1)
                {
                    Debug.Log("Ganaste 1");
                    // cambiar escena victory
                }

                else
                {
                    Debug.Log("No es la llave 1");
                }

            }
        }
    }
}
