﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateInvincible : StateMachineBehaviour
{
    PlayerController PC;
    float Timer;
    float ActivateTime;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC = animator.transform.root.GetComponent<PlayerController>();
        Timer = 0;
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
