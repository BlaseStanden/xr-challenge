using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public  CharacterController controller; 
    
    public float characterMovement = 5f;
    public float characterSprint = 7f;

    public float turnTime = 0.1f;
    public float turnVol;

    public float characterJumpVerVol;
    public float characterGravity = 25f;
    public float characterJumpForce = 10f;

    public AudioSource jump;

    private Vector3 characterMoveDir = Vector3.zero;
        
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        characterMoveDir = new Vector3(horizontal, 0f, vertical).normalized;
       
        ////Jumping///       
        if (controller.isGrounded) // Check if player is grounded to allow to jump
        {
            characterJumpVerVol = -0.5f;
            characterJumpVerVol = -characterGravity * Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                jump.Play();
                characterJumpVerVol = characterJumpForce;
            }
        }
        else
        {
            characterJumpVerVol -= characterGravity * Time.deltaTime; 
        }

        ////Sprinting////
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            characterMovement = characterSprint; //Assigns new speed
            
        }
        else
        {
            characterMovement = characterMovement;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            characterMovement = 5f;
        }

        ////Movement////

        Vector3 moveVector = new Vector3(0, characterJumpVerVol, 0);
        controller.Move(moveVector * Time.deltaTime);

        if (characterMoveDir.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(characterMoveDir.x, characterMoveDir.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnVol, turnTime); // Smooths the turn angles of the player

            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            controller.Move(characterMoveDir * characterMovement * Time.deltaTime);
        }
    }
}
