﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSquatWait : PlayerAnimState
{
    [SerializeField]
    float _InputTime;
    public float InputTime
    {
        get { return _InputTime; }
        set { _InputTime = value; }
    }

    PlayerController PC;
    float Timer;
    bool JumpRollingEffectFlg;
    Object JumpRollingEffect;
    GameObject JREffe;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}