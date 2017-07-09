using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSquatAttack : PlayerAnimState
{
    [SerializeField]
    float _AnimateTime;
    public float AnimateTime
    {
        get { return _AnimateTime; }
        set { _AnimateTime = value; }
    }
    [SerializeField]
    float _ActivateTime;
    public float ActivateTime
    {
        get { return _ActivateTime; }
        set { _ActivateTime = value; }
    }
    [SerializeField]
    Vector2 _velo;
    public Vector2 velo
    {
        get { return _velo; }
        set { _velo = value; }
    }
    private float Timer;
    float dir;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.gameObject.layer = 10;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = Vector2.zero;
        PC.gameObject.layer = 9;
    }
}
