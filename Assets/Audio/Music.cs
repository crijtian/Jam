using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Music : MonoBehaviour
{
    [SerializeField] AudioSource music;
    
    public void OnMusic()
    {
        music.Play();
    }

    public void OffMusic()
    {
        music.Stop();
    }
}
