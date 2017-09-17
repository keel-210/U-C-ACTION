using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMove : PlayerAnimState
{
    [SerializeField]
    AnimationCurve XSpeed, YSpeed;
    [SerializeField]
    float MaxX, MaxY;

    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float x = XSpeed.Evaluate(playeranimator.InStateTimer) * MaxX;
        float y = YSpeed.Evaluate(playeranimator.InStateTimer) * MaxY;
        rb.velocity = new Vector2(playeranimator.Direction * x, y);
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
