using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update

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
    }
}
