using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleManager : MonoBehaviour
{
    public GameObject puzzleUnhide;
    public GameObject puzzleGrabbed;
    public GameObject keyObject;

    public GameObject hideMirror;

    //public Animator puzzle1;
    //public Animator puzzle2;
    //public Animator puzzle3;
    //public Animator puzzle4;

    private bool isDoorUnlocked = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "puzzleGrab")
        {
            Destroy(puzzleGrabbed);
            puzzleUnhide.SetActive(true);
            hideMirror.SetActive(false);

            keyObject.SetActive(true);
            isDoorUnlocked = true;
        }
    }
}
