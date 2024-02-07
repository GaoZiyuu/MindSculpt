using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class happy : MonoBehaviour
{
    public bool happyCorrect = false;
    public GameObject happyMaskHid;
    public GameObject happyMaskGrab;
    public GameObject wrongUI;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "happy_mask")
        {
            happyMaskHid.SetActive(true);
            Destroy(happyMaskGrab);
            happyCorrect = true;
        }
        else if (other.gameObject.tag != "happy_mask")
        {
            happyCorrect = false;
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
