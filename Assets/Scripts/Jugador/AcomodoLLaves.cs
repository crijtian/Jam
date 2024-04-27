using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcomodoLLaves : MonoBehaviour
{
    public GameObject[] objectsToPlace; // Arreglo de objetos a reacomodar
    public PolygonCollider2D areaCollider; // Collider que delimita el espacio de reordenación

    void Start()
    {
        PlaceObjects();
    }

    void PlaceObjects()
    {
        if (areaCollider == null)
        {
            Debug.LogError("PolygonCollider2D no asignado en RandomObjectPlacer.");
            return;
        }

        // Obtener el área del collider
        Vector2[] colliderPoints = areaCollider.GetPath(0);

        for (int i = 0; i < objectsToPlace.Length; i++)
        {
            // Generar una posición aleatoria dentro del collider
            Vector2 randomPosition = GetRandomPositionInsideCollider(colliderPoints);

            // Asignar la posición aleatoria al objeto
            objectsToPlace[i].transform.position = randomPosition;
        }
    }

    Vector2 GetRandomPositionInsideCollider(Vector2[] colliderPoints)
    {
        // Generar una posición aleatoria dentro de los límites del collider
        float x = Random.Range(areaCollider.bounds.min.x, areaCollider.bounds.max.x);
        float y = Random.Range(areaCollider.bounds.min.y, areaCollider.bounds.max.y);
        Vector2 randomPosition = new Vector2(x, y);

        // Verificar si la posición está dentro del collider
        if (areaCollider.OverlapPoint(randomPosition))
        {
            return randomPosition;
        }
        else
        {
            // Si la posición no está dentro del collider, generar otra posición aleatoria
            return GetRandomPositionInsideCollider(colliderPoints);
        }
    }
}
