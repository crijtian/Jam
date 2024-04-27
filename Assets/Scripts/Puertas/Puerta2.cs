using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta2 : MonoBehaviour
{

    public numeroRND numeroRND;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("p1"))
        {

            if (numeroRND.hasKey == 3)
            {

                if (numeroRND.door2)
                {
                    Debug.Log("Ganaste 2");
                    // cambiar escena victory
                }

                else
                {
                    Debug.Log("No es la llave 2");
                }

            }
        }
    }
}
