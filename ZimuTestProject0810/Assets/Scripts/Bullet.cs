using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject deathEffect;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<Animator>().SetTrigger("Die");
            Instantiate(deathEffect, other.transform.position + new Vector3(0,0.99f,0), other.transform.rotation);
            //Destroy(other.gameObject);
            Destroy(gameObject);
            other.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
