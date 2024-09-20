using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gu : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        //Debug.Log("222");
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000f);
            //Debug.Log("111");
        }
    }
}
