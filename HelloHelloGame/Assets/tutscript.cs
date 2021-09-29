using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutscript : MonoBehaviour
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
        Invoke("tutorialStart", 3f);
        
    }
    
    public void tutorialStart()
    {
        tutAnim.SetBool("playtut", true);
        floatJoystick.SetActive(true);
        fixedJoystick.SetActive(true);
        jumpbutton.SetActive(true);
    }
}
