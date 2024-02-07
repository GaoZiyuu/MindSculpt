/* 
 * Author : Gao Ziyu
 * Date: 31/01/2024
 * Description: ?
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BipolarBGM : MonoBehaviour
{
    /// <summary>
    /// audio sources
    /// </summary>
    public AudioSource calm;
    public AudioSource mania;
    public AudioSource depressive;

    /// <summary>
    /// when player enters trigger box, specific audio plays
    /// </summary>
    /// <param name="other"></param>
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
