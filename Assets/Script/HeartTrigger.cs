/* 
 * Author : Gao Ziyu
 * Date: ??
 * Description: ?
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartTrigger : MonoBehaviour
{
    public Transform tp_point;

    public bool moodDone = false;

    public Animator chain;
    public Animator chain2;
    public Animator chain3;
    public Animator chain4;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "mood_stabiliser")
        {
            //play animation
            chain.SetBool("move", true);
            chain2.SetBool("move2", true);
            chain3.SetBool("move3", true);
            chain4.SetBool("move4", true);

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
