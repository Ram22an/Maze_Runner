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
    public AudioSource EnemyKilled;
    public AudioSource YouWinSound;
    public AudioSource YouLooseSound;
    public AudioSource CoinSound;
    public AudioSource PlayerGettinghit;
    void Awake()
    {
        MakeInstance();
        BackGround.Play();

    }
    public void StopBackgroundMusic()
    {
        BackGround.loop = false;
        BackGround.Stop();
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
    public void EnemyKilledSound()
    {
        EnemyKilled.Play();
    }

    public void PlayerWinSound()
    {
        YouWinSound.Play();
    }

    public void PlayerDeathSound()
    {
        YouLooseSound.Play();
    }

    public void CoinCollectSound() 
    {
        CoinSound.Play();
    }
    public void PlayerGettingHurt()
    {
        PlayerGettinghit.Play();
    }
    public void FaddAwayFun()
    {
        StartCoroutine(FaddedAway());
    }
    IEnumerator FaddedAway()
    {
        while (BackGround.volume > 0)
        {
            BackGround.volume -= 1 * Time.deltaTime; // Reduce volume gradually over time
            yield return null;
        }
        
        /**BackGround.volume -= 10;
        yield return null;
        StartCoroutine(FaddedAway());**/
    }




}//class
