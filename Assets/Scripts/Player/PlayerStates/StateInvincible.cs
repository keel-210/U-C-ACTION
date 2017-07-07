using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateInvincible : PlayerAnimState
{
    PlayerController PC;
    float Timer;
    float ActivateTime;
    Rigidbody2D rb;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (rb)
            rb = animator.transform.parent.GetComponent<Rigidbody2D>();
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
