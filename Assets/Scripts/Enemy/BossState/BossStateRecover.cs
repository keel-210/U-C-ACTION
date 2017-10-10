using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStateRecover : EnemyAnimState
{
    [SerializeField]
    int RecoverLimit;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(EC.health < RecoverLimit)
        {
            EC.health++;
        }
        else
        {
            EC.health = RecoverLimit;
        }
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
