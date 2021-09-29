using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class teleportlevel4 : MonoBehaviour
{
    public GameObject btnRef;
    public GameObject movementRef;

    private void OnTriggerEnter(Collider other)
    {
        movementRef.SetActive(false);
        //btnRef.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //public void LoadDemoScene()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //}
}
