/* 
 * Author : Pang Le Xin
 * Date: 01/02/2024
 * Description: controls the animation for the closet door
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script controls the animation of a closet door when a player enters or exits its trigger area.
/// </summary>
public class closetAniScript : MonoBehaviour
{
    public Animator rightAni; // Animator component for the right door
    public Animator LeftAni; // Animator component for the left door

    /// <summary>
    /// Called when another collider enters the trigger zone of this object.
    /// </summary>
    /// <param name="other">The collider that entered the trigger zone.</param>
    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the "Player" tag
        if (other.gameObject.tag == "Player")
        {
            // Open both doors
            rightAni.SetBool("isOpen", true);
            LeftAni.SetBool("isOpen", true);
        }
    }

    /// <summary>
    /// Called when another collider exits the trigger zone of this object.
    /// </summary>
    /// <param name="other">The collider that exited the trigger zone.</param>
    private void OnTriggerExit(Collider other)
    {
        // Check if the colliding object has the "Player" tag
        if (other.gameObject.tag == "Player")
        {
            // Close both doors
            rightAni.SetBool("isOpen", false);
            LeftAni.SetBool("isOpen", false);
        }
    }
}
