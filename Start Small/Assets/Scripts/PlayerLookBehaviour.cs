using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookBehaviour : MonoBehaviour
{
    //how fast the mouse will rotate the transform
    public float mouseSensitivity;
    
    //reference to the transform
    private Transform selfTransform;

    //reference to the camera
    public Transform playerCamera;

    private float xRotation;

    void Start()
    {
        //assign reference to the self transform
        selfTransform = transform;

        //lock the cursor to the middle of the screen
        Cursor.lockState = CursorLockMode.Locked;

        //starts the camera looking at the player
        playerCamera.LookAt(selfTransform, selfTransform.up);
    }

    // Update is called once per frame
    void Update()
    {
        //gets the mouse x axis
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //camera looking for up and down, rotates the camera around the player instead of itself
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        playerCamera.RotateAround(selfTransform.position, -selfTransform.right, mouseY);
    
        //rotates the player transform along the x axis
        selfTransform.Rotate(Vector3.up * mouseX);
    }
}
