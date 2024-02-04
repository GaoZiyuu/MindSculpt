using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calories : MonoBehaviour
{
    public GameObject Green;
    public GameObject Burger;
    public GameObject Egg;
    public GameObject Red;



    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Green")
        {
            Destroy(other.gameObject);
            Green.SetActive(true);
        }

        else if (other.gameObject.tag == "Burger")
        {
            Destroy(other.gameObject);
            Burger.SetActive(true);
        }

        else if (other.gameObject.tag == "Egg")
        {
            Destroy(other.gameObject);
            Egg.SetActive(true);

        }
        else if (other.gameObject.tag == "Red")
        {
            Destroy(other.gameObject);
            Red.SetActive(true);
        }

    }


}
