using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeforeQuiz : MonoBehaviour
{
    public GameObject waterBoat;
    public GameObject waterFront;
    public GameObject startSchooling;
    public GameObject leaveForSchool;

    public GameObject QuizManager;

    public GameObject DemoSceneRef;

    void Start()
    {
        waterBoat.SetActive(false);
        waterFront.SetActive(false);
        startSchooling.SetActive(false);
        leaveForSchool.SetActive(false);
    }
    public void LoadLeaveForSchool()
    {
        leaveForSchool.SetActive(true);
    }

    public void LoadWaterBoat()
    {
        leaveForSchool.SetActive(false);
        waterBoat.SetActive(true);
        //RenderSettings.skybox = nightskybox;
    }

    public void LoadQuiz()
    {
        startSchooling.SetActive(false);
    }


    void Update()
    {
        
    }

    public void LoadDemoSceneAgain()
    {
        DemoSceneRef.SetActive(true);
    }

}
