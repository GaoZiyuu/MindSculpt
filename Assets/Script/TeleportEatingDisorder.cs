/* 
 * Author : Leong Yen Zhen
 * Date: 01/02/2024
 * Description: Script for teleportng player
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportEatingDisorder : MonoBehaviour
{
    /// <summary>
    /// gameobject to store points and UI
    /// </summary>
    public Transform tp_location;
    public GameObject Frames;
    public GameObject UI;
    public GameObject EndGV;

    /// <summary>
    /// when player enters the trigger, they will be teleported
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Frames.SetActive(true);
            UI.SetActive(true);
            EndGV.SetActive(true);
            other.transform.position = tp_location.position;
            other.transform.rotation = tp_location.rotation;

        }
    }
}
