using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateAttack2 : PlayerAnimState
{
    private bool ZeroFlg, NextAttack;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        NextAttack = false;
        ZeroFlg = false;
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = Vector2.zero;
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
