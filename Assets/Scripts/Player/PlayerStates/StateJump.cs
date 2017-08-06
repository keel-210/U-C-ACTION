
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateJump : PlayerAnimState
{
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = new Vector2(rb.velocity.x, rb.gravityScale * PC.PP.JumpPower);
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = new Vector2(rb.velocity.x, rb.gravityScale * PC.PP.JumpPower);
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
