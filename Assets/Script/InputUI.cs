using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputUI : MonoBehaviour
{
    public TMP_InputField ageInput;
    public TMP_Dropdown genderDropdown;
    public TMP_Dropdown messageInput;
    public UserDataManager dataManager;


    public void SaveUserData()
    {
        string gender = genderDropdown.options[genderDropdown.value].text;
        int age = int.Parse(ageInput.text);
        string message = messageInput.options[messageInput.value].text;


        dataManager.SaveUserData(gender, age, message);
    }
}
