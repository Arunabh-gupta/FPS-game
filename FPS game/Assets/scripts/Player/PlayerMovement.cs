using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    CharacterController characterController;

    public float jumpSpeed = 8.0f;

    public float gravity = 20.0f;

    public float speed = 9.0f;

    private Vector3 moveDirection = Vector3.zero;
    
    private void Start()

    {

        characterController = GetComponent<CharacterController>();

    }

    void Update()

    {

        var horizontal = Input.GetAxis("Horizontal");

        var vertical = Input.GetAxis("Vertical");

        transform.Translate(transform.right * horizontal * speed + transform.forward * vertical * speed);
        

        if (characterController.isGrounded)

        {

            moveDirection = transform.right * horizontal * speed + transform.forward * vertical * speed;

            if (Input.GetButton("Jump"))

            {

                moveDirection.y = jumpSpeed;

            }

        }

        moveDirection.y -= gravity * Time.deltaTime;

        characterController.Move(moveDirection * Time.deltaTime);
    }
}
