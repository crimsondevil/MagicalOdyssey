//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Level1Manager : MonoBehaviour
//{
//    public GameObject playerModel;
//    public ThirdPersonMovement thirdPersonScriptReference;

//    public GameObject fixedJoystick;
//    public GameObject floatingJoystick;
//    public GameObject jumpButton;
//    //public GameObject throwButton;

//    public Transform readAnimTPLocation;
//    public Transform dungeonTPLocation;

//    public GameObject playerRef;


//    public GameObject MainMenuUI;

//    void Start()
//    {
//        MainMenuUI.SetActive(true);
//    }

//    void Update()
//    {
        
//    }

//    public void startReadAnim()
//    {
//        Debug.Log("inStart");
//        MainMenuUI.SetActive(false);

//        playerModel.SetActive(false);
//        thirdPersonScriptReference.lockMovementInput();

//        fixedJoystick.SetActive(false);
//        floatingJoystick.SetActive(false);
//        jumpButton.SetActive(false);

//        playerRef.transform.position = readAnimTPLocation.position;
//        playerRef.transform.rotation = readAnimTPLocation.rotation;


//    }

//    public void endReadAnim()
//    {
//        playerModel.SetActive(true);
//        thirdPersonScriptReference.unlockMovementInput();

//        fixedJoystick.SetActive(true);
//        jumpButton.SetActive(true);
//        floatingJoystick.SetActive(true);

//        playerRef.transform.position = dungeonTPLocation.position;
//        playerRef.transform.rotation = dungeonTPLocation.rotation;
//    }

//}
