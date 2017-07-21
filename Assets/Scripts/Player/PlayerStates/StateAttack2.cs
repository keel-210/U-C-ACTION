using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateAttack2 : PlayerAnimState
{
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ColliderEnable((int)PlayerAttackColliders.Attack2);
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ColliderUnable((int)PlayerAttackColliders.Attack2);
    }
}
