/* 
 * Author : Gao Ziyu
 * Date: 30/01/2024
 * Description: This script is for lock interaction
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyLockInteraction : MonoBehaviour
{
    /// <summary>
    /// game objects
    /// </summary>
    public GameObject animatedKey;
    public GameObject keyObj;
    public GameObject lockObj;
    public GameObject doorObj;
    public GameObject portalVFX;

    /// <summary>
    /// check if door is unlocked
    /// </summary>
    private bool doorUnlocked = false;

    /// <summary>
    /// events when triggered
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        //unlock door when keyObj enters the trigger box
        if(other.gameObject == keyObj && !doorUnlocked)
        {
            StartCoroutine(UnlockDoor());
        }

        //teleport player back to lobby
        if(other.gameObject.tag =="Player" && other.gameObject == portalVFX)
        {
            TeleportToLobby();
        }
    }

    /// <summary>
    /// unlock door event
    /// </summary>
    /// <returns></returns>
    private IEnumerator UnlockDoor()
    {
        if (!doorUnlocked)
        {
            //hides grabbed key
            keyObj.SetActive(false);

            //unhide animated key
            animatedKey.SetActive(true);

            //play animation
            animatedKey.GetComponent<Animator>().SetBool("keyAnim", true);

            yield return new WaitForSeconds(1f);

            //play lock animation after 1 sec
            lockObj.GetComponent<Animator>().SetBool("lockUnlocked", true);

            yield return new WaitForSeconds(2f);
            //hide everything after 2 sec
            HideKeys();

            //door is unlocked
            doorUnlocked = true;

            //play door animation
            doorObj.GetComponent<Animator>().SetBool("unlockedDoor", true);

            //portal obj set active 
            if (portalVFX != null)
            {
                portalVFX.SetActive(true);
            }

        }
    }

    /// <summary>
    /// hide key & lock
    /// </summary>
    private void HideKeys()
    {
        animatedKey.SetActive(false);
        lockObj.SetActive(false);
    }

    /// <summary>
    /// teleport player back to lobby
    /// </summary>
    private void TeleportToLobby()
    {
        SceneManager.LoadScene("Lobby");
    }

    
}
