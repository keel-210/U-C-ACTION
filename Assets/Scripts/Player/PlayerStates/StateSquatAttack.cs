using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSquatAttack : PlayerAnimState
{
    [SerializeField]
    Vector2 velo;
    Vector2 rbVelo;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ChangeLayer2Invincible();
        PC.ColliderEnable((int)PlayerAttackColliders.SquatAttack);
        rbVelo = new Vector2(velo.x * playeranimator.Direction, velo.y);
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = rbVelo;
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = Vector2.zero;
        PC.ChangeLayer2Default();
        PC.ColliderUnable((int)PlayerAttackColliders.SquatAttack);
    }
}
