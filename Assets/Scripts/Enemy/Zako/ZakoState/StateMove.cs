using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMove : EnemyAnimState
{
    [SerializeField]
    float Speed;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float x = animator.GetFloat("PosDifX");
        float y = animator.GetFloat("PosDifY");
        Vector2 dif = new Vector2(x, y);
        rb.velocity =  dif.normalized * Speed;
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
