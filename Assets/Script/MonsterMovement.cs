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
    public float moveSpeed = 1f;  // Speed of the monster
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
            monsterScream.Play();
            errorMsgTxt.text = "Incorrect code. Try again.";
            //StartCoroutine(restartScene());
        }
    }

    private IEnumerator restartScene()
    {
        monsterScream.Play();
        yield return new WaitForSeconds(3f);
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
        yield return null;
    }
    public void startLoadScene()
    {

        SceneManager.LoadScene("Lobby");
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
        StartCoroutine(monsterComingIn());
    }

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
