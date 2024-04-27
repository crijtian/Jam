using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class malo_ : MonoBehaviour
{

    private GameManager gameManager;

    private bool canDamage = false; // Controla si el enemigo puede hacer da�o
    private float initialDelay = 2f; // Delay inicial antes de que el enemigo pueda hacer da�o
    public bool bandera = true;

   //creacion de vida del z
   [SerializeField] private float vida;

    private void Start()
    {

        StartCoroutine(EnableDamageAfterDelay()); // Iniciar la corrutina solo una vez al inicio
        gameManager = FindObjectOfType<GameManager>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (bandera) { 
        if (collision.gameObject.CompareTag("p1") && canDamage)
        {
            gameManager.PerderVida();
                gameManager.bandera = false;
                bandera = false;
                StartCoroutine(Golpe());
        }
       }
    }

    //zombie muere si asume da�o
    public void TomarDa�o(float da�o)
    {
        vida -= da�o;
        if (vida <= 0)
        {
            Muerte();
        }
    }

    private void Muerte()
    {
        Destroy(gameObject);
    }

    IEnumerator EnableDamageAfterDelay()
    {
        yield return new WaitForSeconds(initialDelay);
        canDamage = true; // Permite que el enemigo haga da�o despu�s del delay inicial
    }

    IEnumerator Golpe()
    {
        yield return new WaitForSeconds(3f);
        gameManager.bandera = true;
        bandera = true;
    }
}
