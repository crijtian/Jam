using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oleadasAdmin : MonoBehaviour
{
    [SerializeField] private int cantidadDeZombies = 0;
    // Método para sumar un número a la variable

    //Llaves funcionales
    public GameObject llaveF1;
    public GameObject llaveF2;
    public GameObject llaveF3;


    public void Sumar(int valor)
    {
        cantidadDeZombies += valor;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cantidadDeZombies == 0)
        {
            //mensaje de bien venida
        }
        if (cantidadDeZombies == 20)
        {
            llaveF1.SetActive(true);
            //mensaje siguiente ronda
        }
        if (cantidadDeZombies == 40)
        {
            llaveF2.SetActive(true);
            //mensaje siguiente ronda
        }
        if (cantidadDeZombies > 60)
        {
            llaveF3.SetActive(true);
            //mensaje siguiente ronda
        }
    }
}
