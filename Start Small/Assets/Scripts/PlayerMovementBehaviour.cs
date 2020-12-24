using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    
    public CharacterController characterController;
    public float moveSpeed;
    public float gravity;

    public bool canJump;
    public float jumpHeight = 3;

    public Transform groundChecker;
    public float groundCheckerRadius;
    public LayerMask groundMask;

    private Vector3 gravityVector;
     private bool isGrounded;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }


    // Update is called once per frame
    void Update()
    {
        //casts a sphere check, if its touching the ground, will return true
        isGrounded = Physics.CheckSphere(groundChecker.position, groundCheckerRadius, groundMask);

        if(isGrounded && gravityVector.y < 0) //if touching the ground and is falling
        {
            gravityVector.y = -2f; //this forces the player down on the ground
        }

        float xMovement = Input.GetAxis("Horizontal");
        float zMovement = Input.GetAxis("Vertical");

        Vector3 movementVector = (transform.right * xMovement) + (transform.forward * zMovement);

        characterController.Move(movementVector * moveSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded && canJump)
        {
            gravityVector.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        gravityVector.y += gravity * Time.deltaTime;

        characterController.Move(gravityVector * Time.deltaTime);

    }
}
