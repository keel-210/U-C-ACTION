
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSquat : PlayerAnimState
{
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = Vector2.zero;
        PC.ChangeColliderSize(new Vector2(1.5f,1.5f));
        PC.ChangeLayer2Squat();
        playeranimator.JumpRollinged = 0;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = Vector2.zero;
        base.DirectionFix();
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = Vector2.zero;
        //PC.ChangeLayer2Default();
        PC.ChangeColliderSize2Default();
    }
}
