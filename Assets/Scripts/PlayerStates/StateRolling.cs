﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateRolling : StateMachineBehaviour
{
    private PlayerController PC;
    float move;
    float Timer;
    [SerializeField]
    float _RollingTime;
    public float RollingTime
    {
        get { return _RollingTime; }
        set { _RollingTime = value; }
    }
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC = animator.transform.root.GetComponent<PlayerController>();
        PC.gameObject.layer = 10;
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.gameObject.layer = 10;
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.rb.velocity = Vector2.zero;
        PC.gameObject.layer = 9;
    }
}
