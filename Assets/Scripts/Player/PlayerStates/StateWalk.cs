using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AnimatorParameter;
public class StateWalk : PlayerAnimState
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = playeranimator.Move * Vector2.right * PC.PP.Speed;
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = Vector2.zero;
    }
}