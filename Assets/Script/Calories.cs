/* 
 * Author : Leong Yen Zhen
 * Date: 20/12/2023
 * Description: Script for checking of calories on phone interaction
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calories : MonoBehaviour
{
    /// <summary>
    /// gameobject to store the food 
    /// </summary>
    public GameObject Green;
    public GameObject Burger;
    public GameObject Egg;
    public GameObject Red;


    /// <summary>
    /// when player enter the trigger, object will be destoryed and ui will be set active
    /// </summary>
    /// <param name="other"></param>
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
