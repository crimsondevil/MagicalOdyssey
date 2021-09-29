using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllScenes : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject eagleLetter;
    public GameObject letterScene;
    public GameObject waterBoat;
    public GameObject waterFront;
    public GameObject startSchooling;
    public GameObject level1Instructions;
    public GameObject level2Instructions;
    public GameObject leaveForSchool;

    public Material dayskybox;
    public Material nightskybox;
    public Material skyboxforcanvas;

    // Start is called before the first frame update
    void Start()
    {
        //mainMenu.SetActive(true);
        mainMenu.SetActive(false);
        eagleLetter.SetActive(false);
        letterScene.SetActive(false);
        waterBoat.SetActive(false);
        waterFront.SetActive(false);
        startSchooling.SetActive(false);
        level1Instructions.SetActive(false);
        level2Instructions.SetActive(false);
        //leaveForSchool.SetActive(false);

        leaveForSchool.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadEagleLetterScene()
    {
        mainMenu.SetActive(false);
        eagleLetter.SetActive(true);
        RenderSettings.skybox = dayskybox;
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game!");
        Application.Quit();
    }

    public void LoadLetterScene()
    {
        eagleLetter.SetActive(false);
        letterScene.SetActive(true);
        RenderSettings.skybox = dayskybox;
    }

    public void PrepareForSchool()
    {
        letterScene.SetActive(false);
        level1Instructions.SetActive(true);
        RenderSettings.skybox = skyboxforcanvas;
    }

    public void LoadLeaveForSchool()
    {
        //disable level 1.a prefab


        leaveForSchool.SetActive(true);
    }

    public void LoadWaterBoat()
    {
        leaveForSchool.SetActive(false);
        waterBoat.SetActive(true);
        RenderSettings.skybox = nightskybox;
    }
    public void LoadQuiz()
    {
        startSchooling.SetActive(false);
        //load quiz gameobject
    }

    public void LoadLevel2Instructions()
    {
        //disable quiz gameobject

        level2Instructions.SetActive(true);
    }
}
