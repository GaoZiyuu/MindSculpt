using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BipolarToLobby : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            TeleportToLobby();
        }
    }

    private void TeleportToLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
}
