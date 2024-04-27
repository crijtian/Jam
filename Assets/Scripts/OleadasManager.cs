using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OleadasManager : MonoBehaviour
{
    public GameObject enemigoPrefab;
    public float tiempoEntreOleadas = 10f;
    public int enemigosPorOleadaInicial = 20;
    public int incrementoEnemigosPorOleada = 20; // Cantidad de enemigos adicionales por oleada
    public int oleadasInfinitas = 3; // Cantidad de oleadas infinitas después de las oleadas fijas

    private int enemigosPorOleada;
    private int oleadaActual = 0;
    private int enemigosRestantes = 0;
    private int enemigosDerrotados = 0;
    private bool reiniciandoMapa = false;
    private Transform[] spawners; // Arreglo para almacenar los spawners

    void Start()
    {
        enemigosPorOleada = enemigosPorOleadaInicial;
        spawners = GetComponentsInChildren<Transform>(); // Obtener todos los hijos (incluidos los spawners)
        StartCoroutine(IniciarOleadas());
    }
    IEnumerator IniciarOleadas()
    {
        while (true)
        {
            if (!reiniciandoMapa && enemigosDerrotados >= enemigosPorOleada)
            {
                reiniciandoMapa = true;
                ReiniciarMapa();
                yield return new WaitForSeconds(5f); // Esperar 5 segundos antes de iniciar la siguiente oleada
                IniciarSiguienteOleada();
            }
            yield return null;
        }
    }

    void ReiniciarMapa()
    {
        // Eliminar todos los enemigos del mapa
        GameObject[] enemigos = GameObject.FindGameObjectsWithTag("Enemigo");
        foreach (GameObject enemigo in enemigos)
        {
            Destroy(enemigo);
        }
        // Restablecer variables
        enemigosDerrotados = 0;
        reiniciandoMapa = false;
    }

    void IniciarSiguienteOleada()
    {
        oleadaActual++;
        enemigosPorOleada += incrementoEnemigosPorOleada;
        enemigosRestantes = enemigosPorOleada;
        StartCoroutine(SpawnEnemigos());
    }

    IEnumerator SpawnEnemigos()
    {
        for (int i = 0; i < enemigosPorOleada; i++)
        {
            Transform spawner = spawners[Random.Range(0, spawners.Length)]; // Seleccionar un spawner aleatorio
            Instantiate(enemigoPrefab, spawner.position, spawner.rotation); // Instanciar el enemigo en la posición del spawner
            enemigosRestantes--;
            yield return new WaitForSeconds(1f); // Puedes ajustar el tiempo entre la aparición de cada enemigo
        }
    }

    public void EnemigoDerrotado()
    {
        enemigosDerrotados++;
    }
}