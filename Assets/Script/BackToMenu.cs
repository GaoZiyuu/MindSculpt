/* 
 * Author : Gao Ziyu
 * Date: 06/02/2024
 * Description: This script is to go back to menu
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    /// <summary>
    /// to menu scene
    /// </summary>
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
