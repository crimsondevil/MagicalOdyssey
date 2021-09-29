using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutscript2 : MonoBehaviour
{

    public Animator tutAnim;
    public GameObject fixedJoystick;
    public GameObject jumpbutton;
    public GameObject floatJoystick;


    void Start()
    {
        floatJoystick.SetActive(false);
        fixedJoystick.SetActive(false);
        jumpbutton.SetActive(false);
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Invoke("tutorial2Start", 1f);

    }


    //public void tutorialStart()
    //{
    //    tutAnim.SetBool("playtut", true);
    //    floatJoystick.SetActive(true);
    //    fixedJoystick.SetActive(true);

    //}

    public void tutorial2Start()
    {
        tutAnim.SetBool("playJumptut", true);
        floatJoystick.SetActive(true);
        fixedJoystick.SetActive(true);
        jumpbutton.SetActive(true);
    }
}
