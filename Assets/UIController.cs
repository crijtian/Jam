using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Button _musicButton, _sfxButton;

    public void ToggleMusic()
    {
        AudioManager.Instance.ToggleMusic();
    }

    public void ToggleSFX()
    {
        AudioManager.Instance.ToggleSFX();
    }

    public void MusicVolume(int volume)
    {
        AudioManager.Instance.MusicVolume(volume);
    }

    public void SFXVolume(int volume)
    {
        AudioManager.Instance.SFXVolume(volume);
    }
}
