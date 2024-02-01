using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenAni : MonoBehaviour
{
    public Animator rightAni;
    public Animator LeftAni;

    public Animator Drawer;


    public void Open()
    {
        rightAni.SetBool("isOpen", true);
        LeftAni.SetBool("isOpen", true);
    }

    public void Close()
    {
        rightAni.SetBool("isOpen", false);
        LeftAni.SetBool("isOpen", false);
    }

    public void DrawerOpen()
    {
        Drawer.SetBool("DrawerOpen", true);
    }

    public void DrawerClose()
    {
        Drawer.SetBool("DrawerOpen", false);
    }
}
