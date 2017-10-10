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
    bool Enabled = false;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Enabled = false;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        time = animator.GetFloat("InStateTimer");
        if (time > EnableTime && time < DisableTime && !Enabled)
        {
            EC.ColliderEnable(AttackNum);
            Enabled = true;
        }
        if(time > DisableTime && Enabled)
        {
            EC.ColliderUnable(AttackNum);
            Enabled = false;
        }
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        EC.ColliderUnable(AttackNum);
    }
}
