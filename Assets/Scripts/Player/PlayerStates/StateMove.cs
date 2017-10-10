using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMove : PlayerAnimState
{
    [SerializeField]
    AnimationCurve XSpeed, YSpeed;
    [SerializeField]
    float MaxX, MaxY;

    float dir;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        dir = playeranimator.Direction;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float x = XSpeed.Evaluate(playeranimator.InStateTimer) * MaxX;
        float y = YSpeed.Evaluate(playeranimator.InStateTimer) * MaxY;
        rb.velocity = new Vector2(dir * x, y);
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = Vector2.zero;
    }
}
