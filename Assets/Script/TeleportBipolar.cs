/* 
 * Author : Gao Ziyu
 * Date: 31/01/2024
 * Description: This script is for set teleport point for player to teleport in the Bipolar Disorder Scene
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TeleportBipolar : MonoBehaviour
{
    /// <summary>
    /// teleport point
    /// </summary>
    public Transform tp_location;

    /// <summary>
    /// when player enter the trigger box, player gets teleported
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.transform.position = tp_location.position;
            other.transform.rotation = tp_location.rotation;
        }
    }
}
