﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateAttack2 : PlayerAnimState
{
    [SerializeField]
    float _AnimateTime;
    public float AnimateTime
    {
        get { return _AnimateTime; }
        set { _AnimateTime = value; }
    }
    
    private PlayerController PC;
    private float Timer;
    private bool ZeroFlg, NextAttack;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC = animator.transform.parent.GetComponent<PlayerController>();
        NextAttack = false;
        ZeroFlg = false;
        Timer = 0;
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.rb.velocity = Vector2.zero;
        Timer += Time.deltaTime;
        if (Timer < AnimateTime)
        {
        }
        else
        {
        }
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}