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

    bool HasShot;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        HasShot = false;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(InitTime < playeranimator.InStateTimer && !HasShot)
        {
            Instantiate(PC.PP.Bullet, InitPos, Quaternion.identity);
            HasShot = true;
        }
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
