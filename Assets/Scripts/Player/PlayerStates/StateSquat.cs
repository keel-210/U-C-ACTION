
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSquat : StateMachineBehaviour
{
    PlayerController PC;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC = animator.transform.parent.GetComponent<PlayerController>();
        PC.rb.velocity = Vector2.zero;
        PC.gameObject.layer = 10;
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.gameObject.layer = 9;
    }
}
