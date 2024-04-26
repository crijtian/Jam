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
        LeanTween.moveX(titulo.GetComponent<RectTransform>(), 0, 1f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveX(bplay.GetComponent<RectTransform>(), 0, 1f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveX(bexit.GetComponent<RectTransform>(), 0, 1f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveX(bcredits.GetComponent<RectTransform>(), 0, 1f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveX(bsound.GetComponent<RectTransform>(), -856, 1f).setEase(LeanTweenType.easeOutElastic);
    }

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
        audioSorce = GetComponent<AudioSource>();
        audioSorce.clip = audioClip;
        audioSorce.Play();

        yield return new WaitForSeconds(audioClip.length - 1.3f);

        SceneManager.LoadScene(1);
    }
    IEnumerator PlayAudioAndExitGame()
    {
        audioSorce = GetComponent<AudioSource>();
        audioSorce.clip = audioClip;
        audioSorce.Play();

        yield return new WaitForSeconds(audioClip.length - 1.3f);

        Application.Quit();
    }
}
