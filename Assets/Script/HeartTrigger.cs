/* 
 * Author : Gao Ziyu
 * Date: 26/01/2024
 * Description: This script is for heart interactions with the mood_stabiliser game object
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartTrigger : MonoBehaviour
{
    /// <summary>
    /// teleport point [back to calm state]
    /// </summary>
    public Transform tp_point;

    /// <summary>
    /// mood stabiliser game object
    /// </summary>
    public GameObject mood_stabiliser;

    /// <summary>
    /// check if mood stabiliser interacted with heart
    /// </summary>
    public bool moodDone = false;

    /// <summary>
    /// animators
    /// </summary>
    public Animator chain;
    public Animator chain2;
    public Animator chain3;
    public Animator chain4;

    /// <summary>
    /// when mood stabiliser collides into the heart, calls the following events
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "mood_stabiliser")
        {
            //play animation
            chain.SetBool("move", true);
            chain2.SetBool("move2", true);
            chain3.SetBool("move3", true);
            chain4.SetBool("move4", true);

            //destroy the one on hand grabbed
            Destroy(mood_stabiliser);

            //set interacted to true
            moodDone = true;
        }

        //teleport player back to calm state
        if(other.gameObject.tag == "Player" && moodDone)
        {
            //tp player
            TPplayer(other.gameObject);
        }
    }

    /// <summary>
    /// teleport player to position
    /// </summary>
    /// <param name="player"></param>
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
