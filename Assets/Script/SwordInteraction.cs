/* 
 * Author : Leong Yen Zhen
 * Date: 31/01/2024
 * Description: Script for Frame Interaction in Eating Disorder Scene
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordInteraction : MonoBehaviour
{
    public GameObject correctUI;
    public GameObject wrongUI;
    public GameObject Done;
    public int destroyed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Negative")
        {
            destroyed += 1;

            if (other.gameObject.tag == "Negative" && destroyed < 10)
            {
                Destroy(other.gameObject);

            }

            if (other.gameObject.tag == "Negative" && destroyed == 10)
            {
                Destroy(other.gameObject);

            }

            correctUI.SetActive(true);
            StartCoroutine(WaitCoroutine());
            correctUI.SetActive(false);
        }

        else if (other.gameObject.tag == "Postive")
        {
            wrongUI.SetActive(true);
            
        }


    }

    IEnumerator WaitCoroutine()
    {

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3);

    }
}

