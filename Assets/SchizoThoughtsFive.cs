using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchizoThoughtsFive : MonoBehaviour
{
    public GameObject UI;

    public void start()
    {
        UI.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            UI.SetActive(true);


        }
    }
}
