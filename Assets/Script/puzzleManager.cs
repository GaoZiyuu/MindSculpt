using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleManager : MonoBehaviour
{
    public GameObject puzzleUnhide;
    public GameObject puzzleGrabbed;
    public GameObject keyObject;

    public GameObject hideMirror;

    public Animator puzzle1;
    public Animator puzzle2;
    public Animator puzzle3;
    public Animator puzzle4;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "puzzleGrab")
        {
            Destroy(puzzleGrabbed);
            puzzleUnhide.SetActive(true);
            hideMirror.SetActive(false);

            // Play animations for each animator
            PlayPuzzleAnimation(puzzle1);
            PlayPuzzleAnimation(puzzle2);
            PlayPuzzleAnimation(puzzle3);
            PlayPuzzleAnimation(puzzle4);

            keyObject.SetActive(true);
        }
    }

    private void PlayPuzzleAnimation(Animator animator)
    {
        if (animator != null)
        {
            // Assuming each animator has a boolean parameter named "IsUnlocked"
            animator.SetBool("IsUnlocked", true);
        }
    }
}
