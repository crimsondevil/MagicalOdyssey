using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MazeLevelManager : MonoBehaviour
{
    public GameObject Level3InstructionRef;

    private void Start()
    {
        dispayInstructions();
    }

    public void dispayInstructions()
    {
        Level3InstructionRef.SetActive(true);
    }

} 