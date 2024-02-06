using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class MaskManager : MonoBehaviour
{
    public happy happy;
    public SadFrameTrigger sad;
    public FearFrameTrigger fear;
    public AngerFrameTrigger angry;

    public GameObject puzzleObj;

    private void Update()
    {
        // Check if all four boolean variables are true
        if (AreAllBoolsTrue())
        {
            // Activate the Puzzle GameObject
            puzzleObj.SetActive(true);
        }
        else
        {
            // Deactivate the Puzzle GameObject if any of the boolean variables is false
            puzzleObj.SetActive(false);
        }
    }

    private bool AreAllBoolsTrue()
    {
        if (happy && sad && fear && angry)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
