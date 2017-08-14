using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyAnimState : StateMachineBehaviour
{
    protected EnemyController EC;
    protected Rigidbody2D rb;
    protected Transform tra;
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
            tra = animator.GetComponent<Transform>();
            EC = animator.GetComponent<EnemyController>();
        }
        animator.SetFloat("InStateTimer", 0);
        Enter(animator, stateInfo, layerIndex);
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetInteger("Health", EC.health);
        animator.SetFloat("PosDifX", tra.position.x - player.position.x);
        animator.SetFloat("PosDifY", tra.position.y - player.position.y);
        animator.SetFloat("AbsDifX", Mathf.Abs(animator.GetFloat("PosDifX")));
        animator.SetFloat("AbsDifY", Mathf.Abs(animator.GetFloat("PosDifY")));
        animator.SetBool("Hit", EC.IsHit);
        animator.SetBool("OnGround", EC.OnGround);
        float timer = animator.GetFloat("InStateTimer");
        animator.SetFloat("InStateTimer", timer + Time.deltaTime);
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
