using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private GameObject Player;
    private Rigidbody MyBody;
    private Animator Anim;
    private float Enemy_Speed = 15f;
    private float Enemy_Watch_Treshold = 70f;
    private float Enemy_Attack_Treshold = 6f;
    // Start is called before the first frame update
    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        MyBody=GetComponent<Rigidbody>();
        Anim=GetComponent<Animator>();  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        EnemyAI();
    }

    void EnemyAI()
    {
        //Here we are finding the distance or direction or distance with direction
        Vector3 Distance=Player.transform.position-transform.position;
        //here we are finding the magnitude of vector i.e. the value or underroot((x1^2-x2^2)+(y1^2-y2^2)+(z1^2-z2^2))
        float Magnitude = Distance.magnitude;
        //.Normalize() Makes this vector of magnitude of 1
        Distance.Normalize();

        Vector3 Velocity = Distance * Enemy_Speed;
        if (Magnitude>Enemy_Attack_Treshold && Magnitude < Enemy_Watch_Treshold)
        {
            MyBody.velocity=new Vector3(Velocity.x,MyBody.velocity.y,Velocity.z);
            if (Anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
            {
                Anim.SetTrigger("Stop");
            }
            Anim.SetTrigger("Run");
            transform.LookAt(new Vector3(Player.transform.position.x,
                transform.position.y, Player.transform.position.z));
        }
    }







}//class
