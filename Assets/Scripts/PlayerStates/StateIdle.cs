using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateIdle : StateMachineBehaviour
{
    PlayerController PC;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC = animator.transform.root.GetComponent<PlayerController>();
        PC.rb.velocity = Vector2.zero;
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}