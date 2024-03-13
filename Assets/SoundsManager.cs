using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManager : MonoBehaviour
{
    public AudioSource backgroundMusicPlayer;
    public AudioSource[] SFXPlayer;
    public AudioClip backgroundMusic;
    public AudioClip[] SFX;

    public static SoundsManager instance;
    private void Awake()
    {
        instance = this;

    }

    public void PlayBackgroundMusic(int id)
    {
        backgroundMusicPlayer.PlayOneShot(backgroundMusic);

    }

    public void PlaySound(int id)
    {
        SFXPlayer[0].PlayOneShot(SFX[id]);
    }
}
