using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStateRbFreezeRot : EnemyAnimState
{
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.root.gameObject.layer = 28;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }

}
