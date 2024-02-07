/* 
 * Author : Gao Ziyu
 * Date: 27/01/2024
 * Description: This script is to manage the puzzles when interacted from grab
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleManager : MonoBehaviour
{
    /// <summary>
    /// puzzle gameobj
    /// </summary>
    public GameObject puzzleUnhide;
    public GameObject puzzleGrabbed;

    /// <summary>
    /// key gameobj
    /// </summary>
    public GameObject keyObject;

    /// <summary>
    /// wall obj
    /// </summary>
    public GameObject hideMirror;

    /// <summary>
    /// animators
    /// </summary>
    public Animator puzzle1;
    public Animator puzzle2;
    public Animator puzzle3;
    public Animator puzzle4;

    /// <summary>
    /// event called when the grabbed puzzle enters trigger box
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "puzzleGrab")
        {
            Destroy(puzzleGrabbed);
            //unhide the puzzle
            puzzleUnhide.SetActive(true);
            //hide the mirrored wall
            hideMirror.SetActive(false);

            // Play animations for each animator
            PlayPuzzleAnimation(puzzle1);
            PlayPuzzleAnimation(puzzle2);
            PlayPuzzleAnimation(puzzle3);
            PlayPuzzleAnimation(puzzle4);

            //activate key
            keyObject.SetActive(true);
        }
    }

    /// <summary>
    /// play animation for puzzle
    /// </summary>
    /// <param name="animator"></param>
    private void PlayPuzzleAnimation(Animator animator)
    {
        if (animator != null)
        {
            // Assuming each animator has a boolean parameter named "IsUnlocked"
            animator.SetBool("IsUnlocked", true);
        }
    }
}
