using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float lowPos;
    public float highPos;
    public Transform detectPos;
    public float returnSpeed;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(transform.position.y > lowPos)
            {
                rb.position = new Vector3(rb.position.x, rb.position.y - speed, rb.position.z);
            }
        }
    }

    private void Update()
    {
        Collider[] cols = Physics.OverlapSphere(detectPos.position, 0.5f);
        for (int i = 0; i < cols.Length; i++)
        {
            if (cols[i].gameObject.tag == "Player")
            {
                return;
            }
        }
        if (transform.position.y < highPos)
        {
            rb.position = new Vector3(rb.position.x, rb.position.y + returnSpeed, rb.position.z);
        }
    }
}
