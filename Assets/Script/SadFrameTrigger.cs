/* 
 * Author : Gao Ziyu
 * Date: 07/02/2024
 * Description: This script is for sad mask interact with sad frame
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SadFrameTrigger : MonoBehaviour
{
    /// <summary>
    /// bool to check if sad mask is placed in correct frame
    /// </summary>
    public bool sadCorrect = false;

    /// <summary>
    /// game objects
    /// </summary>
    public GameObject sadMaskHid;
    public GameObject sadMaskGrab;
    public GameObject wrongUI;

    /// <summary>
    /// event on trigger
    /// </summary>
    /// <param name="other"></param>
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sad_mask")
        {
            //set to true
            sadCorrect = true;
            Destroy(sadMaskGrab);
            sadMaskHid.SetActive(true);
            wrongUI.SetActive(false);
        }
        else if(other.gameObject.tag != "sad_mask" && sadCorrect == false)
        {
            //set to false
            sadCorrect = false;
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
