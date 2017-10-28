using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateAttack3 : PlayerAnimState
{
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (animator.GetFloat("InStateTimer") > 0.5f)
        {
            PC.ColliderEnable((int)PlayerAttackColliders.Attack3);
        }
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ColliderUnable((int)PlayerAttackColliders.Attack3);
    }
}
