using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Bengala : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    public GameObject Global;
    public Light2D myLight;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.gameObject.CompareTag("p1"))
        {
            Light2D myLight = GameObject.Find("Global").GetComponent<Light2D>();
            StartCoroutine(ActivacionBengala());
        }
    }

    IEnumerator ActivacionBengala()
    {
        myLight.intensity = 1;
        
        yield return new WaitForSeconds(5f);
        myLight.intensity = 0.007f;
        Destroy(gameObject);
    }
}
