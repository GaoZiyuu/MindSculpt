/* 
 * Author : Gao Ziyu
 * Date: 01/02/2024
 * Description: This script is to set active canvas
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCanvaBipola : MonoBehaviour
{
    /// <summary>
    /// canva gameobj
    /// </summary>
    public GameObject maniaCanva;

    /// <summary>
    /// when collide with player, canva set active
    /// </summary>
    /// <param name="other"></param>
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            maniaCanva.SetActive(true);
        }
    }
}
