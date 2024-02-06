using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FearFrameTrigger : MonoBehaviour
{
    public bool fearCorrect = false;
    public GameObject fearMaskHid;
    public GameObject fearMaskGrab;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "scared_mask")
        {
            fearMaskHid.SetActive(true);
            fearCorrect = true;
            Destroy(fearMaskGrab);
        }
        else
        {
            fearCorrect = false;
            StartCoroutine(ShakeCamera(2f));
        }
    }

    private IEnumerator ShakeCamera(float duration)
    {
        // Logic for camera shake...
        Debug.Log("Camera shake triggered!");

        yield return new WaitForSeconds(duration);

        // Stop or reset camera shake, if applicable...
        Debug.Log("Camera shake stopped!");
    }
}
