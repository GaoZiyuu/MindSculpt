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

public class MonsterMovement : MonoBehaviour
{
    public Transform[] waypoints;
    public float moveSpeed = 3f;  // Speed of the monster
    private int currentWaypointIndex = 0;
    public AudioSource monsterSound;
    public AudioSource monsterScream;
    public AudioSource booksFallSound;
    public AudioSource lightSpoilSound;
    public GameObject lightSource;
    public GameObject ceilingLightObj;
    public AudioSource runningMonsterSound;
    public AudioSource doorBangingSound;
    public TMP_InputField codeInput;
    public TMP_Text errorMsgTxt;
    private string correctCode = "10899";
    public float timeValue = 60;
    public TMP_Text TimerTxt;
    private bool monsterIsBreakingIn = false;

    void Update()
    {
        MoveToWaypoints();

        if (monsterIsBreakingIn )
        {
            TimerCountDown();
        }

        if (timeValue == 0)
        {
            StartCoroutine(restartScene() );
        }
    }

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
    public void CheckCode()
    {
        string enteredCode = codeInput.text;

        if (enteredCode == correctCode)
        {
            // Code is correct, do something here (e.g., proceed to the next level)
            Debug.Log("Code is correct!");
            errorMsgTxt.text = ""; // Clear the error message
            startLoadScene();

        }
        else
        {
            // Code is incorrect, display an error message
            Debug.Log("Incorrect code!");
            playScream();
            errorMsgTxt.text = "Incorrect code. Please try again.";
            //StartCoroutine(restartScene());
        }
    }

    private IEnumerator restartScene()
    {
        playScream();
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(currentScene);
        yield return null;
    }
    public void startLoadScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        currentScene++;
        SceneManager.LoadScene(currentScene);
        Debug.Log("next Scene loading");
        //load scene
    }
    public void playScream()
    {
        monsterScream.Play();
    }

    public void playBooksFallSound()
    {
        booksFallSound.Play();
    }

   public void playLightSpoilSound()
    {
        monsterSound.Stop();
        lightSpoilSound.Play();
        lightSource.SetActive(false);
        ceilingLightObj.SetActive(false);
        StartCoroutine(monsterComingIn());
    }

    private IEnumerator monsterComingIn()
    {
        yield return new WaitForSeconds(10f); 
        runningMonsterSound.Play();
        yield return new WaitForSeconds(5f);
        monsterScream.Play();
        yield return new WaitForSeconds(2f);
        doorBangingSound.Play();
        monsterIsBreakingIn = true;
        yield return null;
    }

    private void TimerCountDown()
    {
        if (timeValue >0)
        {
            timeValue -=Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }
        DisplayTime(timeValue);
    }

    private void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
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
