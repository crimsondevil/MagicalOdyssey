using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameStart : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject eagleLetter;
    public GameObject letterScene;
    public GameObject level1Instructions;
    public GameObject level1pickables;
    public GameObject level1dungeon;
    public GameObject dungeon;

    public Material dayskybox;
    public Material nightskybox;
    public Material skyboxforcanvas;

    void Start()
    {
        mainMenu.SetActive(true);        
        eagleLetter.SetActive(false);
        letterScene.SetActive(false);
        level1Instructions.SetActive(false);
    }
    public void LoadEagleLetterScene()
    {
        mainMenu.SetActive(false);
        eagleLetter.SetActive(true);
        //RenderSettings.skybox = dayskybox;
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
        //RenderSettings.skybox = dayskybox;
    }

    public void PrepareForSchool()
    {
        letterScene.SetActive(false);
        level1dungeon.SetActive(true);
        //level1Instructions.SetActive(true);
        //RenderSettings.skybox = skyboxforcanvas;
    }

    public void LoadDungeon()
    {
        level1dungeon.SetActive(false);
        dungeon.SetActive(true);
    }

    public void LoadLevel1Pickables()
    {
        level1Instructions.SetActive(false);
        level1pickables.SetActive(true);
        //RenderSettings.skybox = skyboxforcanvas;
    }

    public void LoadDemoScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
