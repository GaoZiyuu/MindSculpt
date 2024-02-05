using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;

public class MaskManager : MonoBehaviour
{
    public GameObject happyMask;
    public GameObject sadMask;
    public GameObject angryMask;
    public GameObject scaredMask;

    public GameObject happyFrame;
    public GameObject sadFrame;
    public GameObject angryFrame;
    public GameObject scaredFrame;

    public GameObject puzzlePieceObject;
    public CameraShake cameraShake;

    private void Start()
    {
        cameraShake = Camera.main.GetComponent<CameraShake>();
    }

    private void Update()
    {
        if (CheckMaskPlacement())
        {
            ActivatePuzzlePiece();
        }
        else
        {
            StartCoroutine(ShakeCamera(2f));
        }
    }

    private bool CheckMaskPlacement()
    {
        return (happyMask.transform.parent == happyFrame.transform &&
                sadMask.transform.parent == sadFrame.transform &&
                angryMask.transform.parent == angryFrame.transform &&
                scaredMask.transform.parent == scaredFrame.transform);
    }

    private void ActivatePuzzlePiece()
    {
        puzzlePieceObject.SetActive(true);
    }

    private System.Collections.IEnumerator ShakeCamera(float duration)
    {
        cameraShake.StartShake(duration);
        yield return new WaitForSeconds(duration);
        cameraShake.StopShake();
    }
}
