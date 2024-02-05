using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BipolarBGM : MonoBehaviour
{
    public AudioSource calm;
    public AudioSource mania;
    public AudioSource depressive;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "calm")
        {
            calm.Play();
            mania.Stop();
            depressive.Stop();
        }
        else if (other.gameObject.tag == "mania")
        {
            calm.Stop();
            mania.Play();
            depressive.Stop();
        }
        else if (other.gameObject.tag == "depressive")
        {
            calm.Stop();
            mania.Stop();
            depressive.Play();
        }
    }
}
