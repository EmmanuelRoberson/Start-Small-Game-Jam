using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookBehavior : MonoBehaviour
{
    public float mouseSensitivity;

    public bool UpDownLooking;
    public Transform body;
    private Transform self;
    private float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        self = transform;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX, mouseY;

        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;

        if (UpDownLooking)
        {
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        }
        else
        {
            xRotation = 45;
        }
        
        self.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        body.Rotate(Vector3.up * mouseX);
    }
}
