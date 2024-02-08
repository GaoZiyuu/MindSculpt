/* 
 * Author : Leong Yen Zhen
 * Date: 25/01/2024
 * Description: Script for activating the UI when player steps on trigger
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTrigger : MonoBehaviour
{
    /// <summary>
    /// store the gameobject
    /// </summary>
    public GameObject ThoughtsUI;
    public GameObject Kitchen;

    /// <summary>
    /// when player enter trigger, ui will appears
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ThoughtsUI.SetActive(true);
            Kitchen.SetActive(false);
        }
    }
}
