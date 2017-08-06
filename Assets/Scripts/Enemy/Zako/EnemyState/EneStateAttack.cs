using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneStateAttack : EnemyAnimState
{
    [SerializeField]
    float EnableTime,DisableTime;
    [SerializeField]
    int AttackNum;
    float time;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        time = animator.GetFloat("InStateTimer");
        if (time > EnableTime)
        {
            EC.ColliderEnable(AttackNum);
        }
        if(time > DisableTime)
        {
            EC.ColliderUnable(AttackNum);
        }
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
    }
}
