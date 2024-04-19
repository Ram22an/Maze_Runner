using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAttack : MonoBehaviour
{
    private GameObject AttackPoint;
    private void Awake()
    {
        AttackPoint = GameObject.FindGameObjectWithTag("AttackPoint");
        AttackPoint.SetActive(false);
    }
    public void ActivateAttackPointToTrue()
    {
        AttackPoint.SetActive(true);
    }
    public void ActivateAttackPointToFalse()
    {
        AttackPoint.SetActive(false);
    }
}
