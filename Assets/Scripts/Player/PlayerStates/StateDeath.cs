using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateDeath : StateMachineBehaviour
{
    PlayerController PC;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC = animator.transform.parent.GetComponent<PlayerController>();
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.rb.velocity = new Vector2(PC.rb.velocity.x * 0.5f, PC.rb.velocity.y);
    }
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
