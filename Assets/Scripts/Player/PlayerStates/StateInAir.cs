
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateInAir : PlayerAnimState
{
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        playeranimator.JumpZeroFlg = false;
        PC.ChangeLayer2Default();
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (!playeranimator.Up && !playeranimator.JumpZeroFlg)
        {
            playeranimator.JumpZeroFlg = true;
        }
        rb.velocity = new Vector2(playeranimator.Move * PC.PP.Speed, rb.velocity.y);
        DirectionFix();
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
