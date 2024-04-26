using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public new Camera camera;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        MoverPersonaje();
        OrientarHaciaCursor();
    }

    private void MoverPersonaje()
    {
        // Aquí colocas tu lógica para mover al personaje con las teclas WASD
        // Por ejemplo, usando Input.GetAxis para obtener la dirección de movimiento
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        transform.position += movement * Time.deltaTime;
    }

    private void OrientarHaciaCursor()
    {
        Vector3 mouseWorldPosition = camera.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mouseWorldPosition - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        spriteRenderer.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
