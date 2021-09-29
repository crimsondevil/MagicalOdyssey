using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOnObstacle : MonoBehaviour
{
    public GameObject obstacleRef;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        obstacleRef.SetActive(true);
    }
}
