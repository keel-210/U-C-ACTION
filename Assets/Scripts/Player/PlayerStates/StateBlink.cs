﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateBlink : PlayerAnimState
{
    PlayerController PC;
    float Timer,BlinkTimer;
    Renderer rend;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC = animator.transform.parent.GetComponent<PlayerController>();
        Timer = 0;
        BlinkTimer = 0;
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
