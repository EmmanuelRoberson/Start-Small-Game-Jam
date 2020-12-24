using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookBehaviour : MonoBehaviour
{
    //how fast the mouse will rotate the transform
    public float mouseSensitivity;
    
    //reference to the transform
    private Transform selfTransform;

    void Start()
    {
        //assign reference to the self transform
        selfTransform = transform;

        //lock the cursor to the middle of the screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //gets the mouse x axis
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
    

        //rotates the transform along the x axis
        selfTransform.Rotate(Vector3.up * mouseX);
    }
}
