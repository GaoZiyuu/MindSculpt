using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyLockInteraction : MonoBehaviour
{
    public GameObject animatedKey;
    public GameObject keyObj;
    public GameObject lockObj;
    public GameObject doorObj;
    public GameObject portalVFX;

    private bool doorUnlocked = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == keyObj && !doorUnlocked)
        {
            StartCoroutine(UnlockDoor());
        }

        if(other.gameObject.tag =="Player" && other.gameObject == portalVFX)
        {
            TeleportToLobby();
        }
    }

    private IEnumerator UnlockDoor()
    {
        if (!doorUnlocked)
        {
            keyObj.SetActive(false);

            animatedKey.SetActive(true);
            //play animation

            yield return new WaitForSeconds(1f);

            //play lock animation

            doorUnlocked = true;


            //play door animation

            yield return new WaitForSeconds(2f);
            HideKeys();

            if(portalVFX != null)
            {
                portalVFX.SetActive(true);
            }

        }
    }

    private void HideKeys()
    {
        animatedKey.SetActive(false);
        lockObj.SetActive(false);
    }

    private void TeleportToLobby()
    {
        SceneManager.LoadScene("Lobby");
    }

    
}
