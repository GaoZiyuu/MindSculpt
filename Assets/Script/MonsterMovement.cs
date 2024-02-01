/* 
 * Author : Pang Le Xin
 * Date: 01/02/2024
 * Description: Movement and actions of the monster outside mika's room
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    public Transform[] waypoints;
    public float moveSpeed = 3f;  // Speed of the monster
    private int currentWaypointIndex = 0;
    public AudioSource monsterSound;
    public AudioSource monsterScream;


    void Update()
    {
        MoveToWaypoints();
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

    public void playScream()
    {
        monsterScream.Play();
    }

   
}
