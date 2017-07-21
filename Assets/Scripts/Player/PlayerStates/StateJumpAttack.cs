using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateJumpAttack : PlayerAnimState
{
    [SerializeField]
    Vector2 velo;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ColliderEnable((int)PlayerAttackColliders.JumpAttack);
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = velo;
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ColliderUnable((int)PlayerAttackColliders.JumpAttack);
    }
}
