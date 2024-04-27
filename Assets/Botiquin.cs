using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botiquin : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();//Hacer referencia o ligar al GameManager, incluso los prefaps del botiquin
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("p1"))
        {
            bool vidaRecuperada = gameManager.RecuperarVida();

            if (vidaRecuperada)
            {
                Destroy(this.gameObject);
            }

        }
    }
}
