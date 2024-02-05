using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TeleportBipolar : MonoBehaviour
{
    public Transform tp_location;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.transform.position = tp_location.position;
            other.transform.rotation = tp_location.rotation;
        }
    }
}
