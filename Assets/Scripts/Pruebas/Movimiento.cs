using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del jugador
    private Rigidbody2D rb; // Referencia al Rigidbody2D del jugador

    void Start()
    {
        // Obtener la referencia al Rigidbody2D del jugador
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Obtener la entrada del usuario en los ejes X e Y
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calcular la velocidad del jugador
        Vector2 movement = new Vector2(moveHorizontal, moveVertical) * speed;

        // Aplicar la velocidad al Rigidbody2D del jugador
        rb.velocity = movement;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Si el jugador colisiona con un objeto llamado "Wall"...
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Detener el movimiento del jugador
            rb.velocity = Vector2.zero;
        }
    }
}
