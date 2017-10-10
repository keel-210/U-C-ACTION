using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateIdle : PlayerAnimState
{
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.DirectionFix();
        playeranimator.JumpRollinged = 0;
        PC.ChangeLayer2Default();
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = Vector2.zero;
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}