using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ForkInteraction : MonoBehaviour
{
    public GameObject correctUI;
    public GameObject wrongUI;



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
