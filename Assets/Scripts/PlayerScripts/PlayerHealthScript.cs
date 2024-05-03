using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
    public int Health = 100;
    private PlayerMovement playermovement;
    private Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        playermovement = GetComponent<PlayerMovement>();
        Transform playerChild = transform.Find("Character Forest Guard");
        if (playerChild != null)
        {
            // Get the Animator component of the child GameObject
            anim = playerChild.GetComponent<Animator>();
        }
        else
        {
            Debug.LogWarning("Child GameObject 'Character Forest Guard' not found.");
        }
    }
    void Start()
    {
        GamePlayController.instanceOfGamePlay.DisPlayHealth(Health);
    }
    void Update()
    {
        //Debug.Log(Health);
    }
    public void ApplyDamagePlayer(int DamageAmount)
    {
        SoundScripts.Instance.PlayerGettingHurt();
        Health-=DamageAmount;
        if (Health < 0)
        {
            Health = 0;
        }
        GamePlayController.instanceOfGamePlay.DisPlayHealth(Health);
        if (Health == 0)
        {
            SoundScripts.Instance.PlayerDeathSound();
            playermovement.enabled = false;
            anim.Play("Dead");
            GamePlayController.instanceOfGamePlay.IsPlayerAlive = false;
            GamePlayController.instanceOfGamePlay.GameOver();
        }
    }


}//class
