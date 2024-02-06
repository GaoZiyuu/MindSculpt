using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskManager : MonoBehaviour
{
    public AudioSource maskPlaced;

    public GameObject happyMask;
    public GameObject sadMask;
    public GameObject angryMask;
    public GameObject scaredMask;

    public GameObject happyFrame;
    public GameObject sadFrame;
    public GameObject angryFrame;
    public GameObject scaredFrame;

    public GameObject happyMaskHid;
    public GameObject sadMaskHid;
    public GameObject angryMaskHid;
    public GameObject scaredMaskHid;

    public GameObject puzzlePieceObject;
    // public CameraShake cameraShake;

    private bool maskIncorrect = false;

    private void Start()
    {
        //cameraShake = Camera.main.GetComponent<CameraShake>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Mask"))
        {
            GameObject mask = other.gameObject;

            if (mask == happyMask)
                TryPlaceHappyMaskInFrame(mask, happyFrame, happyMaskHid);
            else if (mask == sadMask)
                TryPlaceMaskInFrame(mask, sadFrame, sadMaskHid);
            else if (mask == angryMask)
                TryPlaceMaskInFrame(mask, angryFrame, angryMaskHid);
            else if (mask == scaredMask)
                TryPlaceMaskInFrame(mask, scaredFrame, scaredMaskHid);
        }
    }

    private void TryPlaceHappyMaskInFrame(GameObject mask, GameObject frame, GameObject hidMask)
    {
        if (mask.transform.parent == null && Vector3.Distance(mask.transform.position, frame.transform.position) < 1f && frame.CompareTag("HappyFrame"))
        {
            mask.transform.parent = frame.transform;
            PlayMaskPlacedAudio();
            UnhideMaskInFrame(hidMask);
            ActivatePuzzlePiece();
        }
        else
        {
            // Perform actions for incorrect placement (e.g., camera shake)
            maskIncorrect = true;
            StartCoroutine(ShakeCamera(2f));
        }
    }

    private void TryPlaceMaskInFrame(GameObject mask, GameObject frame, GameObject hidMask)
    {
        if (mask.transform.parent == null && Vector3.Distance(mask.transform.position, frame.transform.position) < 1f && frame.CompareTag("FrameTag"))
        {
            mask.transform.parent = frame.transform;
            PlayMaskPlacedAudio();
            // Do not unhide the mask for other types
            ActivatePuzzlePiece();
        }
        else
        {
            // Perform actions for incorrect placement (e.g., camera shake)
            maskIncorrect = true;
            StartCoroutine(ShakeCamera(2f));
        }
    }

    private void PlayMaskPlacedAudio()
    {
        if (maskPlaced != null)
        {
            maskPlaced.Play();
        }
    }

    private void ActivatePuzzlePiece()
    {
        puzzlePieceObject.SetActive(true);
    }

    private void UnhideMaskInFrame(GameObject hidMask)
    {
        hidMask.SetActive(true);
    }

    private IEnumerator ShakeCamera(float duration)
    {
        //cameraShake.StartShake(duration);
        yield return new WaitForSeconds(duration);
        //cameraShake.StopShake();
    }
}
