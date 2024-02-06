using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class happy : MonoBehaviour
{
    public bool happyCorrect = false;
    public GameObject happyMaskHid;
    public GameObject happyMaskGrab;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "happy_mask")
        {
            happyMaskHid.SetActive(true);
            happyCorrect = true;
            Destroy(happyMaskGrab);
        }
        else
        {
            happyCorrect = false;
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
