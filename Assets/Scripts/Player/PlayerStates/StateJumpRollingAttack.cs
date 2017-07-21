using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateJumpRollingAttack : PlayerAnimState
{
    [SerializeField]
    Vector2 UpVelo,DownVelo;
    [SerializeField]
    float UpTime;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ChangeLayer2Invincible();
        PC.ColliderEnable((int)PlayerAttackColliders.RollingAttack);
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(playeranimator.InStateTimer < UpTime)
        {
            rb.velocity = Vector3.Lerp(rb.velocity, UpVelo, 0.5f);
        }
        else
        {
            rb.velocity = Vector3.Lerp(rb.velocity, DownVelo, 0.5f);
        }
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ChangeLayer2Default();
        PC.ColliderUnable((int)PlayerAttackColliders.RollingAttack);
    }
}
