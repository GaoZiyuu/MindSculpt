using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTrigger : MonoBehaviour
{
    public GameObject ThoughtsUI;
    public GameObject Kitchen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ThoughtsUI.SetActive(true);
            Kitchen.SetActive(false);
        }
    }
}
