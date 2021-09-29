using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject eagleLetter;
    public Material mat;
    public void PlayGame()
    {
        mainMenu.SetActive(false);
        eagleLetter.SetActive(true);
        
        //Material levelMat = new Material("Assets/AllSkyFree/Epic_BlueSunset/Epic_BlueSunset.mat");
        //Debug.Log(levelMat);
        RenderSettings.skybox = mat;
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game!");
        Application.Quit();
    }
}
