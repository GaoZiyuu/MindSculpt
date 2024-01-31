/* 
 * Author : Leong Yen Zhen
 * Date: 28/01/2024
 * Description: Auth Manager for register and login and sending it to firebase
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartTrigger : MonoBehaviour
{
    public Transform tp_point;

    public bool moodDone = false;

    public GameObject chain1;
    public GameObject chain2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "mood_stabiliser")
        {
            //play animation

            chain1.SetActive(false);
            chain2.SetActive(false);
            moodDone = true;
        }

        if(other.gameObject.tag == "Player" && moodDone)
        {
            //tp player
            TPplayer(other.gameObject);
        }
    }

    private void TPplayer(GameObject player)
    {
        if (tp_point != null)
        {
            // Teleport the player to the specified position
            player.transform.position = tp_point.position;
        }
        else
        {
            Debug.LogError("Teleport point is not assigned in the inspector.");
        }
    }
}
