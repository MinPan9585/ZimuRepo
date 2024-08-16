using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    public float currentTime;

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        GetComponent<Text>().text = "Time: " + currentTime.ToString("0.00");

    }
}
