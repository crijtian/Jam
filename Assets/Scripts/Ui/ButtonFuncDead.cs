using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFuncDead : MonoBehaviour
{
    //Creacion de los objetos de las animaciones.
    [SerializeField] GameObject breplay;
    [SerializeField] GameObject bexit;


    public void Jugar()
    {
        StartCoroutine(PlayAudioAndLoadScene());
    }
    public void Salir()
    {
        StartCoroutine(PlayAudioAndExitGame());
    }


    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator PlayAudioAndLoadScene()
    {
        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene(1);
    }
    IEnumerator PlayAudioAndExitGame()
    {
        yield return new WaitForSeconds(1.3f);

        Application.Quit();
    }

}
