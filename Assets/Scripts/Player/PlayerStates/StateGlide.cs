using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateGlide : PlayerAnimState
{
    [SerializeField]
    float GlideRate;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Vector2 vec = new Vector2(playeranimator.Move * PC.PP.Speed, GlideRate);
        rb.velocity = Vector2.Lerp(rb.velocity, vec, 0.2f);
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
