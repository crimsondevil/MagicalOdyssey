using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ShowLetter : MonoBehaviour
{
    public GameObject ReadLetterCanvas;
    void Start()
    {
        ReadLetterCanvas.SetActive(false);
        Invoke("DisableText", 2f);//invoke after 2 seconds
    }
    void DisableText()
    {
        ReadLetterCanvas.SetActive(true);
    }   
}
