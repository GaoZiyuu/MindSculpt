/*
 * Author : Chok Irene
 * Date : 30/01/2024
 * Description: This script is for set teleport point for player to teleport in the Schizophrenia Scene
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SchizoTele : MonoBehaviour
{

    /// <summary>
    /// when player enter the trigger box, player gets teleported
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Lobby");
        }
    }
}
