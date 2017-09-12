using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateJumpRollingAttack : PlayerAnimState
{
    [SerializeField]
    Vector2 UpVelo,DownVelo;
    [SerializeField]
    float UpTime;
    Vector2 UpVe, DoVe;
    public override void Enter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ChangeLayer2Invincible();
        DirectionFix();
        PC.ColliderEnable((int)PlayerAttackColliders.RollingAttack);
        UpVe = new Vector2(UpVelo.x * playeranimator.Direction, UpVelo.y);
        DownVelo = new Vector2(DownVelo.x * playeranimator.Direction, DownVelo.y);
        rb.velocity = UpVe;
        playeranimator.JumpRollinged++;
    }
    public override void Execute(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        rb.velocity = Vector3.Lerp(rb.velocity, DownVelo, 0.1f);
    }
    public override void Exit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PC.ChangeLayer2Default();
        PC.ColliderUnable((int)PlayerAttackColliders.RollingAttack);
        rb.velocity = Vector2.zero;
    }
}
