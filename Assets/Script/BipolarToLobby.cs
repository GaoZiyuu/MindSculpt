/* 
 * Author : Gao Ziyu
 * Date: 07/02/2024
 * Description: This script is for Bipolar Disorder scene teleport back to Lobby scene on trigger
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BipolarToLobby : MonoBehaviour
{
    /// <summary>
    /// when player enter trigger box, teleport back to lobby
    /// </summary>
    /// <param name="other"></param>
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            TeleportToLobby();
        }
    }

    /// <summary>
    /// teleport back to lobby
    /// </summary>
    private void TeleportToLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
}
