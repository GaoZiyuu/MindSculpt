using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngerFrameTrigger : MonoBehaviour
{
    public bool angerCorrect = false;
    public GameObject angerMaskHid;
    public GameObject angerMaskGrab;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "angry_mask")
        {
            angerMaskHid.SetActive(true);
            angerCorrect = true;
            Destroy(angerMaskGrab);
        }
        else
        {
            angerCorrect = false;
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
