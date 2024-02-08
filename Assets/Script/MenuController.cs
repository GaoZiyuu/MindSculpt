/* 
 * Author : Leong Yen Zhen
 * Date: 06/02/2024
 * Description: Script for the menu UI
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    /// <summary>
    /// when function is called, clinic will change to clinic scene
    /// </summary>
    public void StartBtn()
    {
        SceneManager.LoadScene("Clinic-Start");        
    }

    /// <summary>
    /// when function is called, application will close
    /// </summary>
    public void QuitBtn()
    {
        Application.Quit();
    }
}
