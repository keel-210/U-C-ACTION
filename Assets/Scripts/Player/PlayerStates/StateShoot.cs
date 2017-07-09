using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateShoot : PlayerAnimState
{
    [SerializeField]
    float _AnimateTime;
    public float AnimateTime
    {
        get { return _AnimateTime; }
        set { _AnimateTime = value; }
    }
    [SerializeField]
    Vector3 _InitPos;
    public Vector3 InitPos
    {
        get { return _InitPos; }
        set { _InitPos = value; }
    }
    [SerializeField]
    float _InitTime;
    public float InitTime
    {
        get { return _InitTime; }
        set { _InitTime = value; }
    }


    private float Timer;
    Object bullet;
    float move;
    bool Shotflg;
    float dir;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC = animator.transform.parent.GetComponent<PlayerController>();
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
