using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateRolling : PlayerAnimState
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
    Rigidbody2D rb;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (rb)
            rb = animator.transform.parent.GetComponent<Rigidbody2D>();
        PC.gameObject.layer = 10;
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = Vector2.zero;
        PC.gameObject.layer = 9;
    }
}
