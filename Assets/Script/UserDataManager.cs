/* 
 * Author : Gao Ziyu
 * Date: 06/02/2024
 * Description: This script is for user data and send data to firebase database to store data and be used to display out at dashboard on website
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Extensions;
using Firebase.Auth;

public class UserDataManager : MonoBehaviour
{
    /// <summary>
    /// database reference
    /// </summary>
    DatabaseReference db;

    /// <summary>
    /// Counter for generating unique user IDs
    /// </summary>
    int userCounter = 0;

    private void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task => {
            FirebaseApp app = FirebaseApp.DefaultInstance;
            db = FirebaseDatabase.DefaultInstance.RootReference;
        });
    }

    /// <summary>
    /// save user data
    /// </summary>
    /// <param name="gender"></param>
    /// <param name="age"></param>
    /// <param name="message"></param>
    public void SaveUserData(string gender, int age, string message)
    {
        if (db != null)
        {
            string userId = "user" + userCounter.ToString(); // Generate a unique user ID
            userCounter++;

            //send to FB
            UserData userData = new UserData(gender, age, message);
            string json = JsonUtility.ToJson(userData);
            db.Child("users").Child(userId).SetRawJsonValueAsync(json);
        }
        else
        {
            Debug.LogError("Firebase not initialized!");
        }
    }

    /// <summary>
    /// user data
    /// </summary>
    public class UserData
    {
        public string gender;
        public int age;
        public string message;

        public UserData(string gender, int age, string message)
        {
            this.gender = gender;
            this.age = age;
            this.message = message;
        }
    }
}