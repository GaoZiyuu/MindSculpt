/* 
 * Author : Pang Le Xin
 * Date: 01/02/2024
 * Description: Movement and actions of the monster outside mika's room
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

/// <summary>
/// Controls the movement and behavior of a monster in the game.
/// </summary>
public class MonsterMovement : MonoBehaviour
{
    public Transform[] waypoints; // Array of waypoints for the monster to move between
    public float moveSpeed = 1f; // Speed of the monster
    private int currentWaypointIndex = 0; // Index of the current waypoint
    public AudioSource monsterSound; // Audio source for general monster sound
    public AudioSource monsterScream; // Audio source for the monster's scream
    public AudioSource booksFallSound; // Audio source for the sound of falling books
    public AudioSource lightSpoilSound; // Audio source for spoiling the light
    public GameObject lightSource; // GameObject representing the light source
    public GameObject ceilingLightObj; // GameObject representing the ceiling light
    public AudioSource runningMonsterSound; // Audio source for the sound of a running monster
    public AudioSource doorBangingSound; // Audio source for the sound of banging doors
    public TMP_InputField codeInput; // Input field for entering a code
    public TMP_Text errorMsgTxt; // Text for displaying error messages
    private string correctCode = "10899"; // Correct code to proceed
    public float timeValue = 60; // Time value for countdown
    public TMP_Text TimerTxt; // Text for displaying the countdown timer
    private bool monsterIsBreakingIn = false; // Flag indicating if the monster is breaking in

    /// <summary>
    /// Updates the movement and behavior of the monster.
    /// </summary>
    void Update()
    {
        MoveToWaypoints();

        if (monsterIsBreakingIn)
        {
            TimerCountDown();
        }

        if (timeValue == 0)
        {
            StartCoroutine(restartScene());
        }
    }

    /// <summary>
    /// Moves the monster towards the defined waypoints.
    /// </summary>
    void MoveToWaypoints()
    {
        // Check if there are waypoints
        if (waypoints.Length == 0)
        {
            Debug.LogError("No waypoints assigned to the monster!");
            return;
        }

        // Move towards the current waypoint
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, moveSpeed * Time.deltaTime);

        // Check if the monster has reached the current waypoint
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
        {
            // Move to the next waypoint using a for loop and wrap around
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }

    /// <summary>
    /// Checks the entered code against the correct code.
    /// </summary>
    public void CheckCode()
    {
        string enteredCode = codeInput.text;

        if (enteredCode == correctCode)
        {
            // Code is correct, proceed to the next level
            Debug.Log("Code is correct!");
            errorMsgTxt.text = ""; // Clear the error message
            startLoadScene();
        }
        else
        {
            // Code is incorrect, display an error message
            Debug.Log("Incorrect code!");
            monsterScream.Play();
            errorMsgTxt.text = "Incorrect code. Try again.";
        }
    }

    /// <summary>
    /// Restarts the scene after a delay.
    /// </summary>
    private IEnumerator restartScene()
    {
        monsterScream.Play();
        yield return new WaitForSeconds(3f);
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    /// <summary>
    /// Starts loading the next scene.
    /// </summary>
    public void startLoadScene()
    {
        SceneManager.LoadScene("Lobby");
        Debug.Log("Next Scene loading");
    }

    /// <summary>
    /// Plays the monster's scream sound.
    /// </summary>
    public void playScream()
    {
        monsterScream.Play();
    }

    /// <summary>
    /// Plays the sound of falling books.
    /// </summary>
    public void playBooksFallSound()
    {
        booksFallSound.Play();
    }

    /// <summary>
    /// Plays the sound of spoiling light and triggers the monster coming in.
    /// </summary>
    public void playLightSpoilSound()
    {
        StartCoroutine(monsterComingIn());
    }

    /// <summary>
    /// Coroutine for the sequence of events when the monster is breaking in.
    /// </summary>
    private IEnumerator monsterComingIn()
    {
        monsterIsBreakingIn = true;
        lightSource.SetActive(false);
        yield return new WaitForEndOfFrame();
        monsterSound.Stop();
        yield return new WaitForEndOfFrame();
        lightSpoilSound.Play();
        yield return new WaitForEndOfFrame();
        ceilingLightObj.SetActive(false);
        yield return new WaitForSeconds(3f);
        runningMonsterSound.Play();
        yield return new WaitForSeconds(5f);
        monsterScream.Play();
        yield return new WaitForSeconds(2f);
        doorBangingSound.Play();
    }

    /// <summary>
    /// Handles the countdown timer.
    /// </summary>
    private void TimerCountDown()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }
        DisplayTime(timeValue);
    }

    /// <summary>
    /// Displays the countdown timer in minutes and seconds.
    /// </summary>
    private void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        else if (timeToDisplay > 0)
        {
            timeToDisplay += 1;
        }
        float min = Mathf.FloorToInt(timeToDisplay / 60);
        float sec = Mathf.FloorToInt(timeToDisplay % 60);

        TimerTxt.text = string.Format("{0:00}:{1:00}", min, sec);
    }
}
