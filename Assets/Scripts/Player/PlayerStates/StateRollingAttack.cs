using System.Collections;
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
    float dir;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.gameObject.layer = 10;
    }
    
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity += new Vector2(velo.x * dir, rb.gravityScale * velo.y);
        PC.gameObject.layer = 10;
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.gameObject.layer = 9;
    }
}
