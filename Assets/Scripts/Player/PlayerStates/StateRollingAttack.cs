using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateRollingAttack : PlayerAnimState
{
    [SerializeField]
    Vector2 velo;
    float dir;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ChangeLayer2Invincible();
        PC.ColliderEnable((int)PlayerAttackColliders.RollingAttack);
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity += new Vector2(velo.x * dir, rb.gravityScale * velo.y);
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ChangeLayer2Default();
        PC.ColliderUnable((int)PlayerAttackColliders.RollingAttack);
        rb.velocity = Vector2.zero;
    }
}
