using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionScript : MonoBehaviour
{
    //public GameObject readCanvas = null;
    public GameObject canvas;
    void Start()
    {
        canvas.SetActive(false);
        Debug.Log("made false");
        Invoke("DisableText", 2f);//invoke after 5 seconds
    }
    void DisableText()
    {
        canvas.SetActive(true);
        Debug.Log("made true");
    }
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
