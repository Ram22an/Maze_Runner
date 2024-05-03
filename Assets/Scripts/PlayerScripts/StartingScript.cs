using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingScript : MonoBehaviour
{
    private Animator animator;
    public List<string> animationTriggers = new List<string>();
    void Awake()
    {
        animator = GetComponent<Animator>();
        animationTriggers = new List<string> { "Run", "Jump", "Stop", "Attack", "RunAttack" };
    }
    void Start()
    {
        StartCoroutine(AnimationForPlayer());   
    }
    IEnumerator AnimationForPlayer()
    {
        /*int randomIndex = UnityEngine.Random.Range(0, animationTriggers.Count);
        animator.ResetTrigger(animationTriggers[randomIndex]);
        yield return new WaitForSeconds(5f);
        StartCoroutine(AnimationForPlayer());*/
        while (true) // Loop infinitely
        {
            // Choose a random animation trigger from the list
            int randomIndex = UnityEngine.Random.Range(0, animationTriggers.Count);
            string randomTrigger = animationTriggers[randomIndex];

            // Set the random animation trigger
            animator.SetTrigger(randomTrigger);

            // Wait for a few seconds before choosing another random animation
            yield return new WaitForSeconds(5f);
        }
    }
}
