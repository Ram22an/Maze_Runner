using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackingScript : MonoBehaviour
{
    public LayerMask EnemyLayer;
    public float DamageAmount = 20f;
    private void Update()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, 3f, EnemyLayer);
        if (hits.Length > 0)
        {
            if (hits[0].gameObject.tag == "Enemy")
            {
                Debug.Log("We have hit the enemy");
            }
        }
    }
}
