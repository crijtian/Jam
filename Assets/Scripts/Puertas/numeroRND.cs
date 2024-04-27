using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class numeroRND : MonoBehaviour
{
    // Variables para almacenar el estado de cada puerta y la llave
    public bool door1 = false;
    public bool door2 = false;
    public bool door3 = false;
    public bool door4 = false;
    public int hasKey = 0;

    //Reacttransform

    //Canvas
    public GameObject llave1;
    public GameObject llave2;
    public GameObject llave3;

    

    void Start()
    {

        // Generar un número aleatorio del 1 al 4
        int keyDoor = Random.Range(1, 5);

        // Establecer la puerta con la llave
        switch (keyDoor)
        {
            case 1:
                door1 = true;
                break;
            case 2:
                door2 = true;
                break;
            case 3:
                door3 = true;
                break;
            case 4:
                door4 = true;
                break;
        }

        // Imprimir en la consola
        Debug.Log("Puerta con la llave: " + keyDoor);

    }

    private void Update()
    {
        if(hasKey == 1)
        {
            llave1.SetActive(true);

        }
        if (hasKey == 2)
        {
            llave2.SetActive(true);
        }
        if (hasKey == 3)
        {
            llave3.SetActive(true);
        }
    }
}
