using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScripts : MonoBehaviour
{
    public static SoundScripts Instance;
    public AudioSource BackGround;
    public AudioSource Run;
    public AudioSource Jump;
    public AudioSource Attack;
    void Awake()
    {
        MakeInstance();
        BackGround.Play();

    }
    void MakeInstance()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if(Instance!=null)
        {
            Destroy(Instance);
        }
    }
    public void PlayerISRuning()
    {
        Run.Play();
    }
    public void PlayerStopRunning()
    {
        Run.Stop();
    }
    public void PlayerJumped()
    {
        Jump.Play();
    }
    public void PlayerAttacked()
    {
        Attack.Play();
    }
}//class
