﻿using System.Collections;
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
    Vector2 pos;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        HasShot = false;
        pos = rb.position;
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(InitTime < playeranimator.InStateTimer && !HasShot)
        {
            Instantiate(PC.PP.Bullet, animator.transform.position + playeranimator.Direction * InitPos, animator.rootRotation);
            HasShot = true;
            PC.magic -= spendMagic;
        }
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.position = pos;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
}
