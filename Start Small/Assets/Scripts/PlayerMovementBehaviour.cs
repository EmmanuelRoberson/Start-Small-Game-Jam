using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    public CharacterController characterController;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
            characterController.Move(transform.right * moveSpeed);

        if (Input.GetAxis("Horizontal") > 0)
            characterController.Move(-transform.right * moveSpeed);
    }
}
