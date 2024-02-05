using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenAnimation : MonoBehaviour
{
    public Animator rightAni;
    public Animator LeftAni;

    public Animator Drawer1_1;
    public Animator Drawer1_2;
    public Animator Drawer1_3;

    public Animator Drawer2_1;
    public Animator Drawer2_2;
    public Animator Drawer2_3;

    public Animator Drawer3_1;
    public Animator Drawer3_2;
    public Animator Drawer3_3;


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

    public void Drawer1_1Open()
    {
        Drawer1_1.SetBool("DrawerOpen", true);
    }

    public void Drawer1_1Close()
    {
        Drawer1_1.SetBool("DrawerOpen", false);
    }

    public void Drawer1_2Open()
    {
        Drawer1_2.SetBool("DrawerOpen", true);
    }

    public void Drawer1_2Close()
    {
        Drawer1_2.SetBool("DrawerOpen", false);
    }

    public void Drawer1_3Open()
    {
        Drawer1_3.SetBool("DrawerOpen", true);
    }

    public void Drawer1_3Close()
    {
        Drawer1_3.SetBool("DrawerOpen", false);
    }

    public void Drawer2_1Open()
    {
        Drawer2_1.SetBool("DrawerOpen", true);
    }

    public void Drawer2_1Close()
    {
        Drawer2_1.SetBool("DrawerOpen", false);
    }

    public void Drawer2_2Open()
    {
        Drawer2_2.SetBool("DrawerOpen", true);
    }

    public void Drawer2_2Close()
    {
        Drawer2_2.SetBool("DrawerOpen", false);
    }

    public void Drawer2_3Open()
    {
        Drawer2_3.SetBool("DrawerOpen", true);
    }

    public void Drawer2_3Close()
    {
        Drawer2_3.SetBool("DrawerOpen", false);
    }

    public void Drawer3_1Open()
    {
        Drawer3_1.SetBool("DrawerOpen", true);
    }

    public void Drawer3_1Close()
    {
        Drawer3_1.SetBool("DrawerOpen", false);
    }

    public void Drawer3_2Open()
    {
        Drawer3_2.SetBool("DrawerOpen", true);
    }

    public void Drawer3_2Close()
    {
        Drawer3_2.SetBool("DrawerOpen", false);
    }

    public void Drawer3_3Open()
    {
        Drawer3_3.SetBool("DrawerOpen", true);
    }

    public void Drawer3_3Close()
    {
        Drawer3_3.SetBool("DrawerOpen", false);
    }

}
