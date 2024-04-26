using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
    public float Health = 100f;
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

    public void ApplyDamagePlayer(int DamageAmount)
    {
        Health-=DamageAmount;
        if (Health < 0)
        {
            Health = 0;
        }
        if (Health == 0)
        {
            playermovement.enabled = false;
            anim.Play("Dead");
        }
    }


}//class
