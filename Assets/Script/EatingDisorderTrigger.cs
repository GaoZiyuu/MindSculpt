/* 
 * Author : Leong Yen Zhen
 * Date: 29/01/2024
 * Description: Script for the eating disorder trigger for the audio
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingDisorderTrigger : MonoBehaviour
{
    /// <summary>
    /// audio source to store the sound
    /// </summary>
    public AudioSource voicesSound;
    public AudioSource bgmSound;
    public GameObject GV;

    /// <summary>
    /// when player enter the trigger, the sound will play and stop, and the global volume will be turned off
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Plays an Audio Source
            bgmSound.Play();

            //Stops an Audio Source
            voicesSound.Stop();

            GV.SetActive(false);
        }

    }
}
