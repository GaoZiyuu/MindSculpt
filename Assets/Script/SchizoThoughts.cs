/*
 * Author : Chok Irene
 * Date : 01/02/2024
 * Description: This script is for set the UI to appear when the player hits the box collider for the first poster in the Schizophrenia Train Scene
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchizoThoughts : MonoBehaviour
{
    /// <summary>
    /// canva gameobj
    /// </summary>
    public GameObject UI;

    /// <summary>
    /// for the canva to not appear before collide with player, canva set active
    /// </summary>
    public void start()
    {
        UI.SetActive(false);
    }

    /// <summary>
    /// when collide with player, canva set active
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            UI.SetActive(true);
            

        }
    }
}
