/* 
 * Author : Gao Ziyu
 * Date: 07/02/2024
 * Description: This script is for anger mask interact with anger frame
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngerFrameTrigger : MonoBehaviour
{
    /// <summary>
    /// check if anger mask is placed on the correct frame
    /// </summary>
    public bool angerCorrect = false;

    /// <summary>
    /// game objects
    /// </summary>
    public GameObject angerMaskHid;
    public GameObject angerMaskGrab;
    public GameObject wrongUI;

    /// <summary>
    /// trigger event
    /// </summary>
    /// <param name="other"></param>
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "angry_mask")
        {
            //set to true
            angerCorrect = true;
            Destroy(angerMaskGrab);
            angerMaskHid.SetActive(true);
            wrongUI.SetActive(false);
        }
        else if (other.gameObject.tag != "angry_mask" && angerCorrect == false)
        {
            //set to false
            angerCorrect = false;
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
