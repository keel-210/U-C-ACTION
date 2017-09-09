using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateAirDashAttack : PlayerAnimState
{
    [SerializeField]
    Vector2 Velo;
    float direction;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ColliderEnable((int)PlayerAttackColliders.DashAttack);
        playeranimator.DashAttacked++;
        direction = playeranimator.Direction;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = new Vector2(Velo.x * direction,Velo.y);
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ChangeLayer2Default();
        PC.ColliderUnable((int)PlayerAttackColliders.DashAttack);
    }
}
