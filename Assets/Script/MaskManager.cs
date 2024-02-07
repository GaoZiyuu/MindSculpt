/* 
 * Author : Gao Ziyu
 * Date: 02/02/2024
 * Description: This script is to manage the mask interaction
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskManager : MonoBehaviour
{
    /// <summary>
    /// script references
    /// </summary>
    public happyFrameTrigger happy;
    public SadFrameTrigger sad;
    public FearFrameTrigger fear;
    public AngerFrameTrigger angry;

    /// <summary>
    /// puzzle game object
    /// </summary>
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

    /// <summary>
    /// check if all bools from the sccripts == true
    /// </summary>
    /// <returns></returns>
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
