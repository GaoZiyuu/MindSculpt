using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeBottle : MonoBehaviour
{
    public GameObject mood_stabiliser;
    public Animator bottle;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            mood_stabiliser.SetActive(true);
            bottle = GetComponent<Animator>();
        }
    }
}
