using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2_Manager : MonoBehaviour
{
    public GameObject playerModel;
    public ThirdPersonMovement thirdPersonScriptReference;
    public GameObject BasketBallUI;
    public GameObject fixedJoystick;
    public GameObject jumpbutton;
    public GameObject level2UI;

    public Transform Level2playerTeleportLocation;

    public Transform Level3playerTeleportLocation;

    public GameObject playerRef;

    public GameObject ScoreCounterRef;

    public GameObject counterRef;

    //public GameObject scoreRef;

    //public GameObject sliderRef;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void startLevel2()
    {
        //sliderRef.SetActive(true);
        level2UI.SetActive(false);

        playerModel.SetActive(false);
        thirdPersonScriptReference.lockMovementInput();

        fixedJoystick.SetActive(false);
        jumpbutton.SetActive(false);
        BasketBallUI.SetActive(true);

        playerRef.transform.position = Level2playerTeleportLocation.position;
        playerRef.transform.rotation = Level2playerTeleportLocation.rotation;

        ScoreCounterRef.SetActive(true);

        counterRef.GetComponent<scr>().BeginTimer();
        //scoreRef.SetActive(true);

    }

    public void endLevel2()
    {

        playerModel.SetActive(true);
        thirdPersonScriptReference.unlockMovementInput();

        fixedJoystick.SetActive(true);
        jumpbutton.SetActive(true);
        BasketBallUI.SetActive(false);
        level2UI.SetActive(false);

        playerRef.transform.position = Level3playerTeleportLocation.position;
        playerRef.transform.rotation = Level3playerTeleportLocation.rotation;

        //scoreRef.SetActive(false);
        //sliderRef.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        startLevel2UI();

    }

    public void startLevel2UI()
    {
        level2UI.SetActive(true);
    }

}
