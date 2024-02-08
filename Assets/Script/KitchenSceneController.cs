/* 
 * Author : Leong Yen Zhen
 * Date: 05/02/2024
 * Description: Script for scene changing
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KitchenSceneController : MonoBehaviour
{
    /// <summary>
    /// when player enters the trigger, scene will change to lobby scene
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ToLobby")
        {
            SceneManager.LoadScene("Lobby");
        }
    }
}
