/* 
 * Author : Gao Ziyu
 * Date: 07/02/2024
 * Description: This script is for fear mask interact with fear frame
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FearFrameTrigger : MonoBehaviour
{
    /// <summary>
    /// check if fear mask is placed in correct frame
    /// </summary>
    public bool fearCorrect = false;

    /// <summary>
    /// game objects
    /// </summary>
    public GameObject fearMaskHid;
    public GameObject fearMaskGrab;
    public GameObject wrongUI;

    /// <summary>
    /// event on trigger
    /// </summary>
    /// <param name="other"></param>
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "scared_mask")
        {
            //set to true
            fearCorrect = true;
            Destroy(fearMaskGrab);
            fearMaskHid.SetActive(true);
            wrongUI.SetActive(false);

        }
        else if (other.gameObject.tag != "scared_mask" && fearCorrect == false)
        {
            //set to false
            fearCorrect = false;
            wrongUI.SetActive(true);
            StartCoroutine(DeactivateAfterDelay(2f));
        }
    }

    /// <summary>
    /// hide ui after delay
    /// </summary>
    /// <param name="delay"></param>
    /// <returns></returns>
    private IEnumerator DeactivateAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Deactivate the ui after the delay
        wrongUI.SetActive(false);
    }
}
