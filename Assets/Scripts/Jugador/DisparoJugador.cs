using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour
{
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private Transform bala;
    [SerializeField] private float tiempoEntreDisparos = 0.5f; // Tiempo en segundos entre cada disparo
    private float tiempoUltimoDisparo; // Tiempo del último disparo realizado

    void Start()
    {
        tiempoUltimoDisparo = -tiempoEntreDisparos; // Inicializamos el tiempo del último disparo para permitir el primer disparo inmediatamente
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= tiempoUltimoDisparo + tiempoEntreDisparos)
        {
            // Funcion disparo
            Disparar();
            tiempoUltimoDisparo = Time.time; // Actualizamos el tiempo del último disparo
        }
    }

    private void Disparar()
    {
        Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);
    }
}
