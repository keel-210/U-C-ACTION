using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AnimatorParameter;
public class StateWalk : PlayerAnimState
{
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.DirectionFix();
        rb.velocity = playeranimator.Move * Vector2.right * PC.PP.Speed;
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = Vector2.zero;
    }
}