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

    public void DrawerOpen()
    {
        rightAni.SetBool("DrawerOpen", true);
        LeftAni.SetBool("DrawerOpen", true);
    }

    public void DrawerClose()
    {
        rightAni.SetBool("DrawerOpen", false);
        LeftAni.SetBool("DrawerOpen", false);
    }
}
