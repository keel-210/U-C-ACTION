﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateDoubleJump : PlayerAnimState
{
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        playeranimator.HasDoubleJumped = true;
        rb.velocity = new Vector2(rb.velocity.x, rb.gravityScale * PC.PP.SecondJumpPower);
        PC.ChangeLayer2Squat();
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = new Vector2(rb.velocity.x, rb.gravityScale * PC.PP.SecondJumpPower);
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
