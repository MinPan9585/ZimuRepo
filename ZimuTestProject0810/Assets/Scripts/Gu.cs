using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gu : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000f);
        }
    }
}
