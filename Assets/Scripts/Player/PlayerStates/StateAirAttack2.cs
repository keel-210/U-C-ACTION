﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateAirAttack2 : PlayerAnimState
{
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ColliderEnable((int)PlayerAttackColliders.AirAttack2);
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ColliderUnable((int)PlayerAttackColliders.AirAttack2);
    }
}