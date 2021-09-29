using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitdungeonTB : MonoBehaviour
{
    public GameObject Level1Instructions;
    public GameObject DungeonRef;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Level1Instructions.SetActive(true);
        DungeonRef.SetActive(false);
    }
}
