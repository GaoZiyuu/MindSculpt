using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskManager : MonoBehaviour
{
    public happyFrameTrigger happy;
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
    }

    private bool AreAllBoolsTrue()
    {
        if (happy.happyCorrect && sad.sadCorrect && fear.fearCorrect && angry.angerCorrect)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
