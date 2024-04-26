using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EfectoDeSonido : MonoBehaviour
{
    public AudioSource source { get { return GetComponent<AudioSource>(); } }
    public Button play { get {  return GetComponent<Button>(); } }
    public AudioClip clip;

    void Start(){
        gameObject.AddComponent<AudioSource>();
        play.onClick.AddListener(PlaySound);
    }

    void PlaySound (){
        source.PlayOneShot(clip);
    }
}
