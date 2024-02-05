using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingDisorderAudio : MonoBehaviour
{
    public AudioSource voicesSound;
    public AudioSource HeartbeatSound;
    public AudioSource bgmSound;
    public void Voices()
    {
        //Plays an Audio Source
        voicesSound.Play();
    }
    public void Heartbeat()
    {
        //Plays an Audio Source
        HeartbeatSound.Play();
    }
    public void bgm()
    {
        //Plays an Audio Source
        bgmSound.Play();
    }
}
