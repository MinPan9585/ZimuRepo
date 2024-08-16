using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject coinFX;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(coinFX, transform.position, Quaternion.identity);
            Destroy(gameObject);
            other.gameObject.GetComponent<Player>().coinNum++;
        }
    }

    private void Update()
    {
        transform.Rotate(Vector3.forward, 90 * Time.deltaTime);
    }
}
