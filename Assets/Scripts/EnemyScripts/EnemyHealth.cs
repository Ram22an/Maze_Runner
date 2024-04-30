using Cinemachine.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float Health = 70f;
    private EnemyScript enemyscript;
    private Animator anim;
    private EnemyHealthBarScript enemyHealthBarScript;
    // Start is called before the first frame update
    void Awake()
    {
        enemyscript = GetComponent<EnemyScript>();
        anim = GetComponent<Animator>();
        enemyHealthBarScript = GetComponentInChildren<EnemyHealthBarScript>();
    }

    public void ApplyDamageEnemy(int DamageAmount)
    {
        enemyHealthBarScript.UpdateHealthBar(70f,Health);
        Health -= DamageAmount;
        if (Health < 0)
        {
            Health = 0;
        }
        if (Health == 0)
        {
            enemyscript.enabled = false;
            anim.Play("Dead");
            SoundScripts.Instance.EnemyKilledSound();
            StartCoroutine(DeadEnemy());
        }
    }
    IEnumerator DeadEnemy()
    {
        yield return new WaitForSeconds(3f);
        gameObject.SetActive(false);
    }
}//class 
