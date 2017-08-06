using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneStateMove : EnemyAnimState
{
    [SerializeField]
    float Speed;
    [SerializeField]
    Vector2 dif;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float x = animator.GetFloat("PosDifX");
        float y = animator.GetFloat("PosDifY");
        dif = new Vector2(x, y);
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity =  dif.normalized * Speed;
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
