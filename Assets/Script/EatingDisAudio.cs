/* 
 * Author : Leong Yen Zhen
 * Date: 28/01/2024
 * Description: Script for the audio in the eating disorder scene
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingDisAudio : MonoBehaviour
{
    /// <summary>
    /// gameobject to store audiosource
    /// </summary>
    public AudioSource voicesSound;
    public AudioSource HeartbeatSound;
    public AudioSource bgmSound;

    /// <summary>
    /// function to play the voice sound
    /// </summary>
    public void Voices()
    {
        //Plays an Audio Source
        voicesSound.Play();
    }

    /// <summary>
    /// function to play the heartbeat sound
    /// </summary>
    public void Heartbeat()
    {
        //Plays an Audio Source
        HeartbeatSound.Play();
    }

    /// <summary>
    /// function to play the bgm sound
    /// </summary>
    public void bgm()
    {
        //Plays an Audio Source
        bgmSound.Play();
    }
}
