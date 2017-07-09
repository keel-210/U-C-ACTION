using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateHit : PlayerAnimState
{
    [SerializeField]
    float _AnimateTime;
    public float AnimateTime
    {
        get { return _AnimateTime; }
        set { _AnimateTime = value; }
    }
    private float Timer;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Timer = 0;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
