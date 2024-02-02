using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManiaTrigger : MonoBehaviour
{
    public Transform tp_to_mania;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TeleportToMania(other.transform);
        }
    }

    void TeleportToMania(Transform playerTransform)
    {
        playerTransform.position = tp_to_mania.position;
    }
}
