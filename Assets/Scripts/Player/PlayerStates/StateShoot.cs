using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StateShoot : PlayerAnimState
{
    [SerializeField]
    Vector3 InitPos;
    [SerializeField]
    float InitTime;
    [SerializeField]
    int spendMagic;
    bool HasShot;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        HasShot = false;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(InitTime < playeranimator.InStateTimer && !HasShot)
        {
            //Instantiate(PC.PP.Bullet, animator.transform.position + InitPos, Quaternion.identity);
            HasShot = true;
            PC.magic -= spendMagic;
        }
        rb.velocity = Vector2.zero;
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
