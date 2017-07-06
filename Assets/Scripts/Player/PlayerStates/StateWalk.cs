using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AnimatorParameter;
public class StateWalk : StateMachineBehaviour
{
    [SerializeField]
    float Speed;
    private PlayerController PC;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC = animator.transform.parent.GetComponent<PlayerController>();
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.rb.velocity = Vector2.right * Speed;
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.rb.velocity = Vector2.zero;
    }
}