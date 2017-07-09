using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateJumpRollingAttack : PlayerAnimState
{
    [SerializeField]
    Vector2 _vec;
    public Vector2 vec
    {
        get { return _vec; }
        set { _vec = value; }
    }
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.gameObject.layer = 10;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.gameObject.layer = 9;
    }
}
