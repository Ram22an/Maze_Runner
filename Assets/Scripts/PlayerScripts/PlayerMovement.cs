using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float rotY;
    private float TurnSpeed=1f;
    private float moveForward, RotateLeftorRight;
    private CharacterController characterController;
    private Rigidbody myBody;
    public float Speed = 100f;
    // Start is called before the first frame update
    void Awake()
    {
        myBody=GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        //RotateLeftorRight = 0;
        moveForward = 0;
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
        rotY += RotateLeftorRight * TurnSpeed;
        myBody.rotation=Quaternion.Euler(0,rotY,0);
        characterController.Move(new Vector3(0f, 0f, Speed * moveForward*Time.deltaTime));

    }






}//class
