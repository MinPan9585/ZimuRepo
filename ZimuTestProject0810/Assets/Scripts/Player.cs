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
    public GameObject gameOverUI;
    public GameObject gameWinUI;
    public Image takeoverImage;
    public GameObject takeOverUI;
    float takeoverValue = 0;

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

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Lava")
        {
            //Debug.Log("Game Over");
            gameOverUI.SetActive(true);
        }
        if (other.tag == "TakeOverPoint")
        {
            takeOverUI.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
            takeoverValue += Time.deltaTime * 2;
            takeoverImage.fillAmount = takeoverValue / 100;
            //print(takeoverValue);
            if (takeoverValue >= 100)
            {
                //print("Game Victory");
                gameWinUI.SetActive(true);
            }
        
    }
}
