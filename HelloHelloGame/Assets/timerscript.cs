using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerscript : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    //Text countDownText;

    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        //countDownText.text = currentTime.ToString("0");
    }
}
