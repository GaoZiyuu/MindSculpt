using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FearFrameTrigger : MonoBehaviour
{
    public bool fearCorrect = false;
    public GameObject fearMaskHid;
    public GameObject fearMaskGrab;
    public GameObject wrongUI;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "scared_mask")
        {
            fearCorrect = true;
            Destroy(fearMaskGrab);
            fearMaskHid.SetActive(true);
            wrongUI.SetActive(false);

        }
        else if (other.gameObject.tag != "scared_mask" && fearCorrect == false)
        {
            fearCorrect = false;
            wrongUI.SetActive(true);
            StartCoroutine(DeactivateAfterDelay(2f));
        }
    }

    private IEnumerator DeactivateAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Deactivate the ui after the delay
        wrongUI.SetActive(false);
    }
}
