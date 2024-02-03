using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ForkInteraction : MonoBehaviour
{
    public GameObject correctUI;
    public GameObject wrongUI;
    public int Checked;



    private void OnTriggerEnter(Collider other)
    {

        if (Checked >= 4)
        {
            if (other.gameObject.tag == "GreenT")
            {
                Destroy(other.gameObject);
                correctUI.SetActive(true);
            }

            else if (other.gameObject.tag == "BurgerT")
            {
                Destroy(other.gameObject);
                wrongUI.SetActive(true);
            }

            else if (other.gameObject.tag == "EggT")
            {
                Destroy(other.gameObject);
                wrongUI.SetActive(true);

            }
            else if (other.gameObject.tag == "RedT")
            {
                Destroy(other.gameObject);
                wrongUI.SetActive(true);
            }
        }



    }
}
