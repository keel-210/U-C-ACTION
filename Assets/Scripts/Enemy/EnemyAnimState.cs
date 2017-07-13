using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyAnimState : StateMachineBehaviour
{
    protected Rigidbody2D rb;
    protected Transform player;

    private void Awake()
    {
        player = GameObject.Find("Player").transform;
    }

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (rb == null)
        {
            rb = animator.GetComponent<Rigidbody2D>();
        }
        Enter(animator, stateInfo, layerIndex);
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Execute(animator, stateInfo, layerIndex);
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Exit(animator, stateInfo, layerIndex);
    }
    public virtual void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }
    public virtual void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }
    public virtual void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }
}
