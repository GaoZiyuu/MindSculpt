using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SadFrameTrigger : MonoBehaviour
{
    public bool sadCorrect = false;
    public GameObject sadMaskHid;
    public GameObject sadMaskGrab;
    public GameObject wrongUI;


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sad_mask")
        {
            sadMaskHid.SetActive(true);
            Destroy(sadMaskGrab);
            sadCorrect = true;
        }
        else
        {
            sadCorrect = false;
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
