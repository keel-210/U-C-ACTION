using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSquatWait : PlayerAnimState
{
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ChangeColliderSize(new Vector2(3, 3));
        PC.ChangeLayer2Squat();
        rb.velocity = Vector2.zero;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(animator.GetFloat("InStateTimer") > 0.5f)
        {
            PC.WaitEffect.SetActive(true);
        }
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ChangeLayer2Default();
        PC.WaitEffect.SetActive(false);
    }
}
