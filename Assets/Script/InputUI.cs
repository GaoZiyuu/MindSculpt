/* 
 * Author : Gao Ziyu
 * Date: 06/02/2024
 * Description: This script is to get data from the UI to be send to firebase database
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputUI : MonoBehaviour
{
    /// <summary>
    /// UI
    /// </summary>
    public TMP_InputField ageInput;
    public TMP_Dropdown genderDropdown;
    public TMP_Dropdown messageInput;
    public UserDataManager dataManager;

    /// <summary>
    /// get values
    /// </summary>
    public void SaveUserData()
    {
        string gender = genderDropdown.options[genderDropdown.value].text;
        int age = int.Parse(ageInput.text);
        string message = messageInput.options[messageInput.value].text;


        dataManager.SaveUserData(gender, age, message);
    }
}
