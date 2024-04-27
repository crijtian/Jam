using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta4 : MonoBehaviour
{

    public numeroRND numeroRND;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("p1"))
        {

            if (numeroRND.hasKey == 3)
            {

                if (numeroRND.door4)
                {
                    Debug.Log("Ganaste 4");
                    // cambiar escena victory
                }

                else
                {
                    Debug.Log("No es la llave 4");
                }

            }
        }
    }
}
