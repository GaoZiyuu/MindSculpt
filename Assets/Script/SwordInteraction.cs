/* 
 * Author : Leong Yen Zhen
 * Date: 31/01/2024
 * Description: Script for Frame Interaction in Eating Disorder Scene
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* 
 * Author : Leong Yen Zhen
 * Date: 30/01/2024
 * Description: Script for sword interaction in eating disorder scene
 */


using TMPro;
using UnityEngine.UI;

public class SwordInteraction : MonoBehaviour
{
    /// <summary>
    /// store gameobject ui
    /// </summary>
    public GameObject correctUI;
    public GameObject wrongUI;
    public GameObject Done;
    public GameObject Sword;
    public int destroyed;
    //public TMP_Text test;

    /// <summary>
    /// when player enters trigger, ui will appears
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Negative")
        {
            destroyed += 1;
            //test.text = "1";
            if (other.gameObject.tag == "Negative" && destroyed < 10)
            {
                Destroy(other.gameObject);
                correctUI.SetActive(true);
                StartCoroutine(WaitCoroutine());

            }

            if (other.gameObject.tag == "Negative" && destroyed == 10)
            {
                Destroy(other.gameObject);
                Done.SetActive(true);
                Destroy(Sword);

            }

            
            
        }

        else if (other.gameObject.tag == "Postive")
        {
            wrongUI.SetActive(true);
            
        }


    }

    /// <summary>
    /// to make the ui close after 5 seconds
    /// </summary>
    /// <returns></returns>
    IEnumerator WaitCoroutine()
    {

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
        correctUI.SetActive(false);

    }
}

