using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int coinNum = 0;
    public Text coinText;

    private void Update()
    {
        coinText.text = "Coins: " + coinNum;    
    }

}
