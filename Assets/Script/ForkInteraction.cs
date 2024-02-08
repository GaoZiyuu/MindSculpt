/* 
 * Author : Leong Yen Zhen
 * Date: 30/01/2024
 * Description: Script for the eating disorder fork interaction
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ForkInteraction : MonoBehaviour
{
    /// <summary>
    /// gameobject to store the UI
    /// </summary>
    public GameObject correctUI;
    public GameObject wrongUI;


    /// <summary>
    /// when fork interact with the tag items, ui will appears
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GreenT")
        {
            
            correctUI.SetActive(true);
        }

        else if (other.gameObject.tag == "BurgerT")
        {
            
            wrongUI.SetActive(true);
        }

        else if (other.gameObject.tag == "EggT")
        {
            
            wrongUI.SetActive(true);

        }
        else if (other.gameObject.tag == "RedT")
        {
            
            wrongUI.SetActive(true);
        }

    }
}
