using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateAttack2 : PlayerAnimState
{
    private bool ZeroFlg, NextAttack;

    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        NextAttack = false;
        ZeroFlg = false;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = Vector2.zero;
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
