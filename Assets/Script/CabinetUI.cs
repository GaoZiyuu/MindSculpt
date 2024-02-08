/* 
 * Author : Leong Yen Zhen
 * Date: 18/12/2023
 * Description: Script for the eating disorder scene cabinet UI gameobject
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetUI : MonoBehaviour
{
    public GameObject Drawer1Animation;
    public GameObject Drawer2Animation;
    public GameObject Drawer3Animation;
    public GameObject CabinetAnimation;
    public GameObject Fridge;

    /// <summary>
    /// When player enter the trigger tag, the animation will play
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Drawer1")
        {
            Drawer1Animation.SetActive(true);
        }

        else if (other.gameObject.tag == "Drawer2")
        {
            Drawer2Animation.SetActive(true);
        }

        else if (other.gameObject.tag == "Drawer3")
        {
            Drawer3Animation.SetActive(true);
        }

        else if (other.gameObject.tag == "Cabinet")
        {
            CabinetAnimation.SetActive(true);
        }

        else if (other.gameObject.tag == "Fridge")
        {
            Fridge.SetActive(true);
        }
    }

    /// <summary>
    /// when player exit the triggerbox, the ainmation will be set to off
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Drawer1")
        {
            Drawer1Animation.SetActive(false);
        }

        else if (other.gameObject.tag == "Drawer2")
        {
            Drawer2Animation.SetActive(false);
        }

        else if (other.gameObject.tag == "Drawer3")
        {
            Drawer3Animation.SetActive(false);
        }

        else if (other.gameObject.tag == "Cabinet")
        {
            CabinetAnimation.SetActive(false);
        }

        else if (other.gameObject.tag == "Fridge")
        {
            Fridge.SetActive(false);
        }
    }




}

