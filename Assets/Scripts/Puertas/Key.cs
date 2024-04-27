using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public numeroRND numeroRND;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "p1")
        {
            numeroRND.hasKey = numeroRND.hasKey + 1;
        }
        Destroy(gameObject);
    }
}