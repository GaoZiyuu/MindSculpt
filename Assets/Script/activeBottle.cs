/* 
 * Author : Gao Ziyu
 * Date: 26/01/2024
 * Description: This script is to set active the mood stabiliser when player enters trigger box
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeBottle : MonoBehaviour
{
    /// <summary>
    /// mood stabiliser gameObj
    /// </summary>
    public GameObject mood_stabiliser;

    /// <summary>
    /// when player enters, unhide mood stabiliser
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            mood_stabiliser.SetActive(true);
        }
    }
}
