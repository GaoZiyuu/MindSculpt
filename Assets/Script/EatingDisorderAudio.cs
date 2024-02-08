/* 
 * Author : Leong Yen Zhen
 * Date: 29/01/2024
 * Description: Script for the eating disorder audio source
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingDisorderAudio : MonoBehaviour
{
    /// <summary>
    /// audio sources
    /// </summary>
    public AudioSource voicesSound;
    public AudioSource HeartbeatSound;
    public AudioSource vomitSound;

    /// <summary>
    /// function to play the voice sound
    /// </summary>
    public void Voices()
    {
        //Plays an Audio Source
        voicesSound.Play();
    }   

    /// <summary>
    /// function to play heartbeat sound
    /// </summary>
    public void Heartbeat()
    {
        //Plays an Audio Source
        HeartbeatSound.Play();
    }

    /// <summary>
    /// function to play vomit sound
    /// </summary>
    public void Vomit()
    {
        vomitSound.Play();  
    }
    
}
