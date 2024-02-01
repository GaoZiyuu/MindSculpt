using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closetAniScript : MonoBehaviour
{
    public Animator rightAni;
    public Animator LeftAni;
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rightAni.SetBool("isOpen", true);
            LeftAni.SetBool("isOpen", true);
        }
        
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rightAni.SetBool("isOpen", false);
            LeftAni.SetBool("isOpen", false);
        }
       
    }
}
