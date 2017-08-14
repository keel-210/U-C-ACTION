using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneStateDeath : EnemyAnimState
{
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        EC.ChangeLayer2Default();
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
