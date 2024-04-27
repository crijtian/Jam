using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class malo_ : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    private bool canDamage = false; // Controla si el enemigo puede hacer da�o
    private float initialDelay = 5f; // Delay inicial antes de que el enemigo pueda hacer da�o

    private void Start()
    {
        StartCoroutine(EnableDamageAfterDelay());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("p1") && canDamage)
        {
            gameManager.PerderVida();
        }
    }

    IEnumerator EnableDamageAfterDelay()
    {
        yield return new WaitForSeconds(initialDelay);
        canDamage = true; // Permite que el enemigo haga da�o despu�s del delay inicial
    }
}
