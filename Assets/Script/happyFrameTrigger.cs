/* 
 * Author : Gao Ziyu
 * Date: 07/02/2024
 * Description: This script is for happy mask interact with happy frame
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class happyFrameTrigger : MonoBehaviour
{
    /// <summary>
    /// bool to check if the mask is placed in the correct frame
    /// </summary>
    public bool happyCorrect = false;

    /// <summary>
    /// game objects
    /// </summary>
    public GameObject happyMaskHid;
    public GameObject happyMaskGrab;
    public GameObject wrongUI;

    /// <summary>
    /// event on trigger
    /// </summary>
    /// <param name="other"></param>
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "happy_mask")
        {
            //set bool to true
            happyCorrect = true;
            Destroy(happyMaskGrab);
            wrongUI.SetActive(false);
            happyMaskHid.SetActive(true);
        }
        else if (other.gameObject.tag != "happy_mask" && happyCorrect == false)
        {
            //set bool to false
            happyCorrect = false;
            wrongUI.SetActive(true);
            StartCoroutine(DeactivateAfterDelay(2f));
        }
    }

    /// <summary>
    /// hides UI after delay
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
