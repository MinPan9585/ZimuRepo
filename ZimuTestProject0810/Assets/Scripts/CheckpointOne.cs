using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointOne : MonoBehaviour
{
    public Transform startTrans;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            startTrans.position = transform.position;
        }   
    }
}
