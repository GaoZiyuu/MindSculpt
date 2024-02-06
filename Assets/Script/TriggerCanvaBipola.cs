using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCanvaBipola : MonoBehaviour
{
    public GameObject maniaCanva;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            maniaCanva.SetActive(true);
        }
    }
}
