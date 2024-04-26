using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageScript : MonoBehaviour
{
    public LayerMask PlayerLayer;
    public float DamageAmount = 2f;
    private void Update()
    {
        Collider[] hits=Physics.OverlapSphere(transform.position, 0.1f,PlayerLayer);
        if(hits.Length > 0)
        {
            if (hits[0].gameObject.tag == "Player")
            {
                Debug.Log("We have hit the player");
            }
        }
    }



}//class
