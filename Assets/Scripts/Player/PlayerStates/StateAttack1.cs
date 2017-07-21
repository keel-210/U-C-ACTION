using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateAttack1 : PlayerAnimState
{
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ColliderEnable((int)PlayerAttackColliders.Attack1);
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ColliderUnable((int)PlayerAttackColliders.Attack1);
    }
}
