using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SadFrameTrigger : MonoBehaviour
{
    public bool sadCorrect = false;
    public GameObject sadMaskHid;
    public GameObject sadMaskGrab;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sad_mask")
        {
            sadMaskHid.SetActive(true);
            sadCorrect = true;
            Destroy(sadMaskGrab);
        }
        else
        {
            sadCorrect = false;
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
