using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportEatingDisorder : MonoBehaviour
{
    public Transform tp_location;
    public GameObject Frames;
    public GameObject UI;
    public GameObject EndGV;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Frames.SetActive(true);
            UI.SetActive(true);
            EndGV.SetActive(true);
            other.transform.position = tp_location.position;
            other.transform.rotation = tp_location.rotation;

        }
    }
}
