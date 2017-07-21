using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSquatWait : PlayerAnimState
{
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ChangeColliderSize(new Vector2(3, 3));
        PC.ChangeLayer2Squat();
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ChangeLayer2Default();
    }
}
