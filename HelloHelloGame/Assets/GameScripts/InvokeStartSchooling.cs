using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeStartSchooling : MonoBehaviour
{
    public float invokeNextSceneAfter = 8f;
    public GameObject startSchooling;
    public GameObject waterFront;
    public Material defaultskybox;

    void Start()
    {
        Invoke("LoadWaterFront", invokeNextSceneAfter);//invoke after 5 seconds
    }

    // Update is called once per frame
    void LoadWaterFront()
    {
        waterFront.SetActive(false);
        startSchooling.SetActive(true);
        Debug.Log("changing skybox");
        //RenderSettings.skybox = defaultskybox;
    }
}
