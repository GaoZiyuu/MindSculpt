using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastAudioTrigger : MonoBehaviour
{
    public AudioSource anxiousSound;
    public AudioSource calm;
    public AudioSource heartbeat;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Plays an Audio Source
            calm.Play();

            //Stops an Audio Source
            anxiousSound.Stop();
            heartbeat.Stop();

        }

    }
}
