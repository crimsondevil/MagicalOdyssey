using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 30f;

    public GameObject Panel;
    public Button nextButton;
    public Text countdownText;
    int goals = 0;

    public BasketBallScore ScoreRef;

    bool startTimer = false;

    public Text finalText;

    public GameObject throwBtnRef;
    public GameObject sliderRef;

    public GameObject scorecountRef;
    public GameObject timercountRef;


    void Start()
    {
        Panel.SetActive(false);
        //nextButton.SetActive(false);
        currentTime = startingTime;
    }

    void closePanel()
    {
        Panel.SetActive(false);
    }

    void Update()
    {
        timer();
    }

    public void BeginTimer()
    {
        currentTime = startingTime;
        startTimer = true;
    }

    public void timer()
    {

        if (startTimer == true)
        {
            currentTime -= 1 * Time.deltaTime;

            if (currentTime <= 10)
            {
                countdownText.color = Color.red;
            }

            countdownText.text = currentTime.ToString("0");

            Debug.Log(countdownText.text);
            if (currentTime <= 0)
            {
                currentTime = 0;
            }

            if (currentTime == 0)
            {
                //nextButton.SetActive(true);
                Panel.SetActive(true);
                startTimer = false;

                sliderRef.SetActive(false);
                throwBtnRef.SetActive(false);

                if (ScoreRef.Score >= 500)
                {
                    scorecountRef.SetActive(false);
                    timercountRef.SetActive(false);
                    WinCondition();
                }

                else if (ScoreRef.Score < 500)
                {
                    scorecountRef.SetActive(false);
                    timercountRef.SetActive(false);
                    LoseCondition();
                }

                nextButton.onClick.AddListener(closePanel);
            }
        }
    }

    private void WinCondition()
    {
        finalText.text = "Congratulations!!! You have passed Level 2";
    }

    private void LoseCondition()
    {
        finalText.text = "Better luck next time";
    }
}
