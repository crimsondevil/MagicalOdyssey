using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4Manager : MonoBehaviour
{
    public Transform Level4TeleportLocation;
    //public GameObject level4UI;

    public GameObject playerRef;

    public void StartLevel4()
    {

        Debug.Log("in trigger");
        Debug.Log(playerRef.transform.position);

        Vector3 tempposition = playerRef.transform.position;

        playerRef.transform.position = Level4TeleportLocation.position;

        Debug.Log(playerRef.transform.position);
        //playerRef.transform.rotation = Level4TeleportLocation.rotation;
    }

    public void EndLevel2()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        StartLevel4();
    }

    private void FixedUpdate()
    {
        Debug.LogError(playerRef.transform.position);
    }
}
