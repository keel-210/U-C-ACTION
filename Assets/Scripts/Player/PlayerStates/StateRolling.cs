using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateRolling : PlayerAnimState
{
    [SerializeField]
    float Speed;
    float dir;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ChangeLayer2Invincible();
        dir = playeranimator.Direction;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = Vector2.right * Speed * dir;
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = Vector2.zero;
        PC.ChangeLayer2Default();
    }
}
