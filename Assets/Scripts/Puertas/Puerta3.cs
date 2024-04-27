using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta3 : MonoBehaviour
{

    public numeroRND numeroRND;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("p1"))
        {

            if (numeroRND.hasKey == 3)
            {

                if (numeroRND.door3)
                {
                    Debug.Log("Ganaste 3");
                    // cambiar escena victory
                }

                else
                {
                    Debug.Log("No es la llave 3");
                }

            }
        }
    }
}
