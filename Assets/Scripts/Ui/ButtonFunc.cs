using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonFunc : MonoBehaviour
{
    //Creacion de los objetos de las animaciones.
    [SerializeField] GameObject bplay;
    [SerializeField] GameObject bcredits;
    [SerializeField] GameObject bexit;
    [SerializeField] GameObject titulo;
    [SerializeField] GameObject bsound;

    //public AudioSource source { get { return GetComponent<AudioSource>(); } }
    //public Button play { get { return GetComponent<Button>(); } }
    //public AudioClip clip;

    public AudioClip audioClip;
    private AudioSource audioSorce;

    //void PlaySound()
    //{
     //   source.PlayOneShot(clip);
    //}

    private void Start()
    {
        LeanTween.moveX(titulo.GetComponent<RectTransform>(), -511, 1f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveX(bplay.GetComponent<RectTransform>(), -628, 1f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveX(bexit.GetComponent<RectTransform>(), -628, 1f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveX(bcredits.GetComponent<RectTransform>(), -628, 1f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveX(bsound.GetComponent<RectTransform>(), 885, 1f).setEase(LeanTweenType.easeOutElastic);
    }

    public void Jugar()
    {
        StartCoroutine(PlayAudioAndLoadScene());
    }
    public void Salir()
    {
        StartCoroutine(PlayAudioAndExitGame());
    }

    public void Creditos()
    {
        StartCoroutine(PlayAudioAndLoadScene2());
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
        yield return new WaitForSeconds(audioClip.length - 1.3f);

        Application.Quit();
    }
    IEnumerator PlayAudioAndLoadScene2()
    {
        yield return new WaitForSeconds(audioClip.length - 1.3f);

        SceneManager.LoadScene(0);
    }
}
