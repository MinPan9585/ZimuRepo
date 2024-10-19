using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gu : MonoBehaviour
{
    public AudioClip guSound;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SFX.instance.PlaySound(guSound, transform.position);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000f);
        }
    }
}
