using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool isMoving = false;
    private float moveForward, rotateInput;
    private float moveSpeed = 25f;
    private float turnSpeed = 120f;
    private CharacterController characterController;    
    private Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        characterController = GetComponent<CharacterController>();
        animator = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
    }
    void Update()
    {
        PlayerMove();
        PlayerAnimation();
    }

    void PlayerAnimation()
    {
        
        if (moveForward > 0)
        {
            animator.ResetTrigger("Stop");
            animator.SetTrigger("Run");
        }
        else
        {
            animator.ResetTrigger("Run");
            animator.SetTrigger("Stop");
            
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            AnimatorClipInfo[] clip = animator.GetCurrentAnimatorClipInfo(0);
            if (clip.Length > 0)
            {
                if (clip[0].clip.name == "run")
                {
                    animator.SetTrigger("RunAttack");
                    SoundScripts.Instance.PlayerAttacked();
                }
                else if (clip[0].clip.name == "idle")
                {
                    animator.SetTrigger("Attack");
                    SoundScripts.Instance.PlayerAttacked();
                }
            }
        }
        if (!characterController.isGrounded)
        {
            AnimatorClipInfo[] clip = animator.GetCurrentAnimatorClipInfo(0);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (clip.Length > 0)
                {
                    if (clip[0].clip.name == "run")
                    {
                        animator.SetTrigger("Jump");
                        SoundScripts.Instance.PlayerJumped();
                    }
                    else if (clip[0].clip.name == "idle")
                    {
                        animator.SetTrigger("Jump");
                        SoundScripts.Instance.PlayerJumped();
                    }
                }
            }
        }
    }




    void PlayerMove()
    {
        moveForward = Input.GetAxisRaw("Vertical");
        rotateInput = Input.GetAxisRaw("Horizontal");
        Vector3 moveDirection = transform.forward * moveForward;
        if (moveForward > 0)
        {
            characterController.Move(moveDirection * moveSpeed * Time.deltaTime);
            if (!isMoving)
            {
                SoundScripts.Instance.PlayerISRuning();
                isMoving = true;
            }
        }
        if (moveForward<=0)
        {
            characterController.Move(moveDirection * 0 * Time.deltaTime);
            if (isMoving)
            {
                SoundScripts.Instance.PlayerStopRunning();
                isMoving = false;
            }
        }
        //if (moveForward==0) {
        //  transform.Rotate(Vector3.up, rotateInput * 0 * Time.deltaTime);
        //}
        //else
        //{
        transform.Rotate(Vector3.up, rotateInput * turnSpeed * Time.deltaTime);
        //}
        

    }

    
        




}//class




 //public float Speed = 50f;
 //private float rotY;
 //private float TurnSpeed=1f;
 //private float moveForward, RotateLeftorRight;
 //private Rigidbody myBody;
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
