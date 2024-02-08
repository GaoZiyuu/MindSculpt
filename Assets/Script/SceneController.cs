/* 
 * Author : Leong Yen Zhen
 * Date: 30/01/2024
 * Description: Script for Changing of scene
 */

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class SceneController : MonoBehaviour
{
    
    /// <summary>
    /// once player enters the triggers, scene will change accordingly
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Schizophrenia")
        {
            SceneManager.LoadScene("Schizophrenia");
        }

        else if (other.gameObject.tag == "EatingDisorder")
        {
            SceneManager.LoadScene("EatingDisorder");
        }

        else if (other.gameObject.tag == "OCD")
        {
            SceneManager.LoadScene("OCD");

        }

        else if (other.gameObject.tag == "BipolarDisorder")
        {
            SceneManager.LoadScene("BipolarDisorder");

        }

        else if (other.gameObject.tag == "End")
        {
            SceneManager.LoadScene("Clinic-End");

        }

        
    }
}
