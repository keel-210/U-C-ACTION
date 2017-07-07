﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateRollingAttack : PlayerAnimState
{
    [SerializeField]
    Vector2 _velo;
    public Vector2 velo
    {
        get { return _velo; }
        set { _velo = value; }
    }
    private PlayerController PC;
    float dir;
    Rigidbody2D rb;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (rb)
            rb = animator.transform.parent.GetComponent<Rigidbody2D>();
        PC.gameObject.layer = 10;
    }
    
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity += new Vector2(velo.x * dir, PC.rb.gravityScale * velo.y);
        PC.gameObject.layer = 10;
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.gameObject.layer = 9;
    }
}