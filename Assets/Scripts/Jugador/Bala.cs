using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float daño;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
    }

    //Impacto con el enemigo
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Proximamanete
        //https://www.youtube.com/watch?v=9Y8GaA9Ka9E
    }

    private void OnBecameInvisible()
    {
        // Destruir la bala cuando sale de la pantalla
        Destroy(gameObject);
    }
}
