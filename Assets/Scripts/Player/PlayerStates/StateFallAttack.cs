﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateFallAttack : PlayerAnimState
{
    [SerializeField]
    Vector2 velo;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.gameObject.layer = 13;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity += velo;
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.gameObject.layer = 9;
    }
}
