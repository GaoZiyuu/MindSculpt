using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Extensions;
using Firebase.Auth;

public class UserDataManager : MonoBehaviour
{
    DatabaseReference db;
    int userCounter = 0; // Counter for generating unique user IDs

    private void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task => {
            FirebaseApp app = FirebaseApp.DefaultInstance;
            db = FirebaseDatabase.DefaultInstance.RootReference;
        });
    }

    public void SaveUserData(string gender, int age, string message)
    {
        if (db != null)
        {
            string userId = "user" + userCounter.ToString(); // Generate a unique user ID
            userCounter++;

            UserData userData = new UserData(gender, age, message);
            string json = JsonUtility.ToJson(userData);
            db.Child("users").Child(userId).SetRawJsonValueAsync(json);
        }
        else
        {
            Debug.LogError("Firebase not initialized!");
        }
    }

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