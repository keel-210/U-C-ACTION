using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneStateMovebyTime : EnemyAnimState
{
    [SerializeField]
    AnimationCurve SpeedCurve;
    [SerializeField]
    bool MovementFor2D;
    Vector2 dif;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float x = animator.GetFloat("PosDifX");
        float y = animator.GetFloat("PosDifY");
        if (MovementFor2D)
        {
            dif = new Vector2(x, y);
        }
        else
        {
            dif = new Vector2(dif.x, 0);
        }
        dif = dif.normalized;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = dif * SpeedCurve.Evaluate(animator.GetFloat("InStateTimer"));
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}

