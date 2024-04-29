using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private GameObject AttackingPoint;
    private GameObject Player;
    private Rigidbody MyBody;
    private Animator Anim;
    private float Enemy_Speed = 10f;
    private float Enemy_Watch_Treshold = 70f;
    private float Enemy_Attack_Treshold = 5f;
    // Start is called before the first frame update
    void Awake()
    {
        AttackingPoint = GameObject.FindGameObjectWithTag("AttackPointEnemy");
        Player = GameObject.FindGameObjectWithTag("PlayerChild");
        MyBody=GetComponent<Rigidbody>();
        Anim=GetComponent<Animator>();  
        AttackingPoint.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GamePlayController.instanceOfGamePlay.IsPlayerAlive)
        {
            EnemyAI();
        }
        else
        {
            if (Anim.GetCurrentAnimatorStateInfo(0).IsName("Attack")|| Anim.GetCurrentAnimatorStateInfo(0).IsName("Run"))
            {
                Anim.SetTrigger("Stop");
            }
        }
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
        else if (Magnitude < Enemy_Attack_Treshold)
        {
            if (Anim.GetCurrentAnimatorStateInfo(0).IsName("Run"))
            {
                Anim.SetTrigger("Stop");
            }
            Anim.SetTrigger("Attack");
            transform.LookAt(new Vector3(Player.transform.position.x,
                transform.position.y, Player.transform.position.z));
        }
        else
        {
            MyBody.velocity = Vector3.zero;
            Anim.SetTrigger("Stop");
        }
    }

    void DamagePointActive()
    {
        AttackingPoint.SetActive(true);
    }
    void DamagePointDeActivate()
    {
        AttackingPoint.SetActive(false);
    }





}//class
