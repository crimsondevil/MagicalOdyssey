using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokewaterFront : MonoBehaviour
{
    public float invokeNextSceneAfter = 5f;
    public GameObject waterBoat;
    public GameObject waterFront;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadWaterFront", invokeNextSceneAfter);//invoke after 5 seconds
    }

    // Update is called once per frame
    void LoadWaterFront()
    {
        waterBoat.SetActive(false);
        waterFront.SetActive(true);
    }
}
