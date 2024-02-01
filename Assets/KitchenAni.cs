using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenAni : MonoBehaviour
{
    public Animator rightAni;
    public Animator LeftAni;
    public GameObject close;


    public void Open()
    {
        rightAni.SetBool("isOpen", true);
        LeftAni.SetBool("isOpen", true);
        close.SetActive(true);
    }

    public void Close()
    {
        rightAni.SetBool("isOpen", false);
        LeftAni.SetBool("isOpen", false);
    }
}
