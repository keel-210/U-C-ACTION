using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateBlink : PlayerAnimState
{
    float Timer,BlinkTimer;
    Renderer rend;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Timer = 0;
        BlinkTimer = 0;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
