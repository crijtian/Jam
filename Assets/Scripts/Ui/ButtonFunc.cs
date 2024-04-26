using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunc : MonoBehaviour
{
    //Creacion de los objetos de las animaciones.
    [SerializeField] GameObject bplay;
    [SerializeField] GameObject bcredits;
    [SerializeField] GameObject bexit;
    [SerializeField] GameObject titulo;
    [SerializeField] GameObject bsound;

    private void Start()
    {
        LeanTween.moveX(titulo.GetComponent<RectTransform>(), 0, 0.5f);
    }

    public void Jugar()
    {
        SceneManager.LoadScene(1);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
