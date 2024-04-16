using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float moveSpeed = 5f;
    private float turnSpeed = 100f;
    //private float rotY;
    //private float TurnSpeed=1f;
    //private float moveForward, RotateLeftorRight;
    private CharacterController characterController;
    //private Rigidbody myBody;
    public float Speed = 10f;
    // Start is called before the first frame update
    void Awake()
    {
        //myBody=GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float moveForward = Input.GetAxisRaw("Vertical");
        float rotateInput = Input.GetAxisRaw("Horizontal");

        Vector3 moveDirection = transform.forward * moveForward;
        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);

        transform.Rotate(Vector3.up, rotateInput * turnSpeed * Time.deltaTime);
        //RotateLeftorRight = 0;
        /***moveForward = 0;
        if (Input.GetAxisRaw("Vertical")>0)
        {
            moveForward = 1;
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            moveForward = -1;
        }
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            RotateLeftorRight = 1;
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            RotateLeftorRight = -1;
            
        }
        //rotY += RotateLeftorRight * TurnSpeed;
        //characterController.transform.Rotate(new Vector3(0f,rotY,0f));
        characterController.Move(new Vector3(0f, 0f, Speed * moveForward*Time.deltaTime));***/

    }






}//class
