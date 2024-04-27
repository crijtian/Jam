using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcomodoLLaves : MonoBehaviour
{
    public GameObject[] objectsToPlace; // Arreglo de objetos a reacomodar
    public PolygonCollider2D areaCollider; // Collider que delimita el espacio de reordenaci�n

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

        // Obtener el �rea del collider
        Vector2[] colliderPoints = areaCollider.GetPath(0);

        for (int i = 0; i < objectsToPlace.Length; i++)
        {
            // Generar una posici�n aleatoria dentro del collider
            Vector2 randomPosition = GetRandomPositionInsideCollider(colliderPoints);

            // Asignar la posici�n aleatoria al objeto
            objectsToPlace[i].transform.position = randomPosition;
        }
    }

    Vector2 GetRandomPositionInsideCollider(Vector2[] colliderPoints)
    {
        // Generar una posici�n aleatoria dentro de los l�mites del collider
        float x = Random.Range(areaCollider.bounds.min.x, areaCollider.bounds.max.x);
        float y = Random.Range(areaCollider.bounds.min.y, areaCollider.bounds.max.y);
        Vector2 randomPosition = new Vector2(x, y);

        // Verificar si la posici�n est� dentro del collider
        if (areaCollider.OverlapPoint(randomPosition))
        {
            return randomPosition;
        }
        else
        {
            // Si la posici�n no est� dentro del collider, generar otra posici�n aleatoria
            return GetRandomPositionInsideCollider(colliderPoints);
        }
    }
}
