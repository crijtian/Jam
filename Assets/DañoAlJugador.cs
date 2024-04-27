using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Malo : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("p1"))
        {
            gameManager.PerderVida();

        }
    }
}

