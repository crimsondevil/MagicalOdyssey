using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
public float movementSpeed = 10f;
public float lookatspeed = 5f;
public FixedJoystick leftjoystick;
public FloatingJoystick rightjoystick;
public Camera cam;
public Animator PlayerAnimator;

    void Update () {
 
        if (Input.GetKey ("w") || (leftjoystick.Vertical >= 0.5f))  {
            transform.position += transform.TransformDirection (Vector3.forward) * Time.deltaTime * movementSpeed;
            //PlayerAnimator.SetBool("iswalking", true);
        }   else if (Input.GetKey ("s") || (leftjoystick.Vertical <= -0.5f)) {
            transform.position -= transform.TransformDirection (Vector3.forward) * Time.deltaTime * movementSpeed;
        }
            else{
        }
 
        if ((Input.GetKey ("a") && !Input.GetKey ("d") )|| (leftjoystick.Horizontal <= -0.5f)){
                transform.position += transform.TransformDirection (Vector3.left) * Time.deltaTime * movementSpeed;
            } else if ((Input.GetKey ("d") && !Input.GetKey ("a")  ) || (leftjoystick.Horizontal >= +0.5f )){
                transform.position -= transform.TransformDirection (Vector3.left) * Time.deltaTime * movementSpeed;
            }
            else{
        }

        if (Input.GetKey ("a") || Input.GetKey ("w") || Input.GetKey ("s") || Input.GetKey ("d")){
            PlayerAnimator.SetBool("iswalking", true);
        }
        else if(!(Input.GetKey ("a") || Input.GetKey ("w") || Input.GetKey ("s") || Input.GetKey ("d"))){
            PlayerAnimator.SetBool("iswalking", false);
        }
        Debug.LogError(PlayerAnimator.GetBool("iswalking"));
        

        float horizontal = rightjoystick.Horizontal * lookatspeed;
		//float vertical = Input.GetAxis("Mouse Y") * lookatspeed;

		transform.Rotate(0f, horizontal, 0f, Space.World);
		//transform.Rotate(-vertical, 0f, 0f, Space.Self);
        }
}