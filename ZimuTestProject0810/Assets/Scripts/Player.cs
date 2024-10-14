using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int coinNum = 0;
    public Text coinText;
    public GameObject bullet;
    public float bulletForce;

    private void Update()
    {
        //coinText.text = "Coins: " + coinNum;
        

        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletIns = Instantiate(bullet, transform.position + new Vector3(0.15f,0.7f,0), transform.rotation);
            Rigidbody rb = bulletIns.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(transform.GetChild(1).forward * bulletForce, ForceMode.Impulse);
            }
        }
    }


}
