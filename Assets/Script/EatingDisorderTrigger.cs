using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingDisorderTrigger : MonoBehaviour
{

    public AudioSource voicesSound;
    public AudioSource bgmSound;
    public GameObject GV;

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
