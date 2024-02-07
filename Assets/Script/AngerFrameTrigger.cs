using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngerFrameTrigger : MonoBehaviour
{
    public bool angerCorrect = false;
    public GameObject angerMaskHid;
    public GameObject angerMaskGrab;
    public GameObject wrongUI;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "angry_mask")
        {
            angerCorrect = true;
            Destroy(angerMaskGrab);
            angerMaskHid.SetActive(true);
            wrongUI.SetActive(false);
        }
        else if (other.gameObject.tag != "angry_mask" && angerCorrect == false)
        {
            angerCorrect = false;
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
