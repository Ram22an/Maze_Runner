using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingScript : MonoBehaviour
{
    public int Choose = 0;
    private Animator animator;
    public List<string> animationTriggers = new List<string>();
    void Awake()
    {
        animator = GetComponent<Animator>();
        //animationTriggers = new List<string> { "Run", "Jump", "Stop", "Attack", "RunAttack" };
    }
    void Start()
    {
        StartCoroutine(AnimationForPlayer());   
    }
    IEnumerator AnimationForPlayer()
    {
        animator.SetInteger("Choose",0);
        animator.SetInteger("Choose",Choose);
        Choose += 1;
        if(Choose==3)
        {
            Choose = 0;
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine(AnimationForPlayer());
    }

}
